import {StyleSheet, Text, View} from "react-native";
import UserInfo from "./UserInfo";
import DateField from "../shared/DateField";
import {useRef, useState} from "react";

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
            setError('Sorry, that is not a valid date! Try again.')
        }
        if(age<18){
            setError('Sorry, you must be older than 18 years old to join.')
        }else if(age>99){
            setError('Sorry, you must be less than 99 years old to join.')
        }

    }
    return (
        <UserInfo
            tilePrefix={'Nice, When is your '}
            titleHighLighted={'birthday'}
            titlePostfix={'?'}
            hint={'This cannot be changed later.'}
            onGoBack={()=>{navigation.navigate('NameScreen')}}
            onContinue={onContinue}
        >

            <DateField onValue={(value:string)=>date.current=value} errorMsg={error}/>
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
