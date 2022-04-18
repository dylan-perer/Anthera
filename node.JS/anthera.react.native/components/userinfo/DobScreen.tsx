import {StyleSheet, Text, View} from "react-native";
import UserInfo from "./UserInfo";
import DateField from "../shared/DateField";
import {useRef, useState} from "react";
import {screenDeviation, verticalScale} from "../../styles/AntheraStyle";

const DobScreen = ({navigation}: {navigation: any})=>{
    const [error, setError] = useState('');
    const date = useRef<string>()

    const onContinue=()=>{
        setError('');

        let age = NaN;

        if(date.current!=null){
            age = calculateAge(new Date(date.current));
        }

        if(isNaN(age)){
            setError('Sorry, that is not a valid date.')
        }
        else if (age<18){
            setError('Sorry, you must be 18 or older to join.')
        }else if(age>99){
            setError('Sorry, your age must be less than 99 to join.')
        }else{
            navigation.navigate('HeretoScreen')
        }

    }
    return (
        <UserInfo
            tilePrefix={'When is your '}
            titleHighLighted={'birthday'}
            titlePostfix={'?'}
            hint={'This cannot be changed later.'}
            onGoBack={()=>{navigation.navigate('NameScreen')}}
            onContinue={onContinue}
            btnStyle={{marginTop: screenDeviation(45,80,85)}}
        >

            <DateField
                styleContainer={{marginTop: screenDeviation(35,30,30)}}
                onValue={(value:string)=>date.current=value}
                errorMsg={error}
                autoFocus={true}/>
        </UserInfo>
    )

}

const calculateAge=(birthday:Date) =>{ // birthday is a date
    const ageDifMs = Date.now() - birthday.getTime();
    const ageDate = new Date(ageDifMs); // miliseconds from epoch
    return Math.abs(ageDate.getUTCFullYear() - 1970);
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});

export default DobScreen;
