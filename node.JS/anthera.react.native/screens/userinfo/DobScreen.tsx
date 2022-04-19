import {StyleSheet, Text, View} from "react-native";
import UserInfo from "./UserInfo";
import AppDateField from "../../components/shared/AppDateField";
import {useContext, useRef, useState} from "react";
import {screenDeviation, verticalScale} from "../../styles/AntheraStyle";
import {NativeStackScreenProps} from "@react-navigation/native-stack";
import {StackParamList} from "../../components/navigators/SignupNavigator";
import {UserInfoContext} from "../../contexts/UserInfoContext";

const DobScreen = ({route, navigation}:NativeStackScreenProps<StackParamList, 'DobScreen'>)=>{
    const [error, setError] = useState('');
    const userInfoContext = useContext(UserInfoContext);

    const onContinue=()=>{
        setError('');

        let age = NaN;

        if(userInfoContext!=null){
            if(userInfoContext.dob!=undefined){
                age = calculateAge(new Date(userInfoContext.dob));
            }
            if(isNaN(age)){
                setError('Sorry, that is not a valid date.');
                return;
            }
            if (age<18) {
                setError('Sorry, you must be 18 or older to join.');
                return;
            }
            if(age>99) {
                setError('Sorry, your age must be less than 99 to join.');
                return;
            }
            console.log(userInfoContext);
            navigation.navigate('HeretoScreen');
        }

    }
    const setDob =(value:string)=>{
        if(userInfoContext!=null){
            userInfoContext.dob = value;
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

            <AppDateField
                value={error==''?userInfoContext?.dob:undefined}
                styleContainer={{marginTop: screenDeviation(35,30,30)}}
                onValue={setDob}
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
