import {StyleSheet, Text, TextInput, View} from "react-native";
import UserInfo from "./UserInfo";
import {AntheraStyle, moderateScale, scale, verticalScale} from "../../styles/AntheraStyle";
import InputField from "../shared/InputField";
import {useRef, useState} from "react";

const NameScreen = ({navigation}: {navigation: any})=>{
    const [error, setError] = useState('');
    const value = useRef<string>();

    const onContinue=()=>{
        if(value.current!=null && value.current.length > 1){
            navigation.navigate('DobScreen');
        }else{
            setError('Sorry, name is too short!');
        }
    }
    return (
        <UserInfo
            tilePrefix={'Okay first, what is your '}
            titleHighLighted={'name'}
            titlePostfix={'?'}
            hint={'This is how others will see you.'}
            onGoBack={()=>{navigation.navigate('SignupScreen')}}
            onContinue={onContinue}
        >
            <InputField
                showCharacterCounter={true}
                maxValueCounter={14}
                errorMsg={error}
                onChange={(text:string)=>{value.current=text}}
                autoFocus={true}
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
