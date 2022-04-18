import UserInfo from "./UserInfo";
import {StyleSheet, View} from "react-native";
import InputField from "../shared/InputField";
import {useRef, useState} from "react";
import {
    AntheraStyle,
    isPhoneScreen,
    isSmallPhoneScreen,
    moderateScale,
    screenDeviation,
    verticalScale
} from "../../styles/AntheraStyle";

const EmailAndPasswordScreen = ({navigation}:{navigation:any})=>{
    const [errorEmail, setErrorEmail] = useState('');
    const emailValue = useRef<string>('');

    const [errorPassword, setErrorPassword] = useState('');
    const passwordValue = useRef<string>('');

    const onContinue = ()=>{
        setErrorPassword('');
        setErrorEmail('');
        if(emailValue.current?.length==0 || emailValue.current!=null && !validateEmail(emailValue.current)){
            setErrorEmail('Sorry, email is not valid!');
            return;
        }
        if(passwordValue.current?.length==0 || passwordValue.current!=null && passwordValue.current.length<6){
            setErrorPassword('Sorry, password must be at least 6 characters long!');
            return;
        }
        navigation.navigate('ProfilePictureScreen');
    }
    return <UserInfo tilePrefix={'Now for an '}
                     titleHighLighted={'email '}
                     titlePostfix={'and '}
                     titleHighLightedEnd={'password.'}
                     hint={'Password must be at least 6 characters!'}
                     onContinue={onContinue}
                     btnStyle={styles.continueBtn}
                     onGoBack={()=>{navigation.navigate('SexPreferenceScreen')}}>
        <View>
            <InputField
                showCharacterCounter={false}
                onChange={(value:string)=>emailValue.current=value}
                maxValueCounter={255}
                errorMsg={errorEmail}
                containerStyle={styles.inputEmailContainer}
                textStyle={styles.input}
                placeholder={'email'}
                isErrorAlignCenter={true}
                autoFocus={true}

            />
            <InputField
                secureTextEntry={true}
                showCharacterCounter={false}
                onChange={(value:string)=>passwordValue.current=value}
                maxValueCounter={255}
                errorMsg={errorPassword}
                containerStyle={styles.inputContainerPassword}
                textStyle={styles.input}
                placeholder={'password'}
                isErrorAlignCenter={true}
                isAutoCorrect={true}
            />
        </View>
    </UserInfo>
}
const validateEmail = (email:string) => {
    return String(email)
        .toLowerCase()
        .match(
            /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
        );
};

const styles = StyleSheet.create({
    input:{
        borderBottomWidth:0
    },
    inputEmailContainer:{
        borderRadius:moderateScale(40),
    },
    inputContainerPassword:{
        marginTop:verticalScale(20),
        borderRadius:moderateScale(40),
    },
    continueBtn:{
        marginTop: screenDeviation(10,30,70)
    }
});


export default EmailAndPasswordScreen;
