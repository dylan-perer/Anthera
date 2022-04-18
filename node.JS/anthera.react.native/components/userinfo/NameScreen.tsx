import {StyleSheet, Text, TextInput, View} from "react-native";
import UserInfo from "./UserInfo";
import {
    AntheraStyle,
    isSmallPhoneScreen,
    moderateScale,
    scale,
    screenDeviation,
    verticalScale
} from "../../styles/AntheraStyle";
import InputField from "../shared/InputField";
import {useRef, useState} from "react";

const NameScreen = ({navigation}: {navigation: any})=>{
    const [error, setError] = useState('');
    const value = useRef<string>();

    const onContinue=()=>{
        setError('');
        if(value.current!=null && value.current.length > 1){
            navigation.navigate('DobScreen');
        }else{
            setError('Sorry, name is too short.');
        }
    }
    return (
        <UserInfo
            tilePrefix={'First, What\'s is your '}
            titleHighLighted={'name'}
            titlePostfix={'?'}
            hint={'This is how others will see you.'}
            onGoBack={()=>{navigation.navigate('SignupScreen')}}
            onContinue={onContinue}
            btnStyle={{marginTop: screenDeviation(45,80,80)}}
        >
            <InputField
                showCharacterCounter={true}
                maxValueCounter={14}
                errorMsg={error}
                onChange={(text:string)=>{value.current=text}}
                autoFocus={true}
                containerStyle={{marginTop: screenDeviation(35,20,20)}}
            />
        </UserInfo>
    )
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});

export default NameScreen;
