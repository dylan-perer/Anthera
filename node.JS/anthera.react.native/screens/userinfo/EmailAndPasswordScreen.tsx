import UserInfo from "./UserInfo";
import {StyleSheet, View} from "react-native";
import AppInputField from "../../components/shared/AppInputField";
import {useContext, useEffect, useRef, useState} from "react";
import {
    AntheraStyle,
    isPhoneScreen,
    isSmallPhoneScreen,
    moderateScale,
    screenDeviation,
    verticalScale
} from "../../styles/AntheraStyle";
import {signupAsync, SignupRequest} from "../../api/AntheraApi";
import {NativeStackScreenProps} from "@react-navigation/native-stack";
import {StackParamList} from "../../components/navigators/SignupNavigator";
import {UserInfoContext} from "../../contexts/UserInfoContext";
import {useIsFocused} from "@react-navigation/native";

const EmailAndPasswordScreen = ({route, navigation}:NativeStackScreenProps<StackParamList, 'EmailAndPasswordScreen'>)=>{

    const userInfoContext = useContext(UserInfoContext);
    const isFocused = useIsFocused();
    const [errorEmail, setErrorEmail] = useState('');
    const [errorPassword, setErrorPassword] = useState('');

    useEffect(()=>{
        setErrorEmail(userInfoContext?.emailDuplicateError?userInfoContext.emailDuplicateError:'');
    },[isFocused])

    const onContinue = async ()=>{
        setErrorPassword('');
        setErrorEmail('');
        if(userInfoContext!=null){
            if(userInfoContext.emailAddress?.length==0 || userInfoContext.emailAddress!=undefined && !validateEmail(userInfoContext.emailAddress)){
                setErrorEmail('Sorry, email is not valid!');
                return;
            }
            if(userInfoContext.password?.length==0 || userInfoContext.password!=undefined && userInfoContext.password.length<6){
                setErrorPassword('Sorry, password must be at least 6 characters long!');
                return;
            }


            navigation.navigate('ProfilePictureScreen');
        }
    }
    const setEmailAddress=(value:string)=>{
        if(userInfoContext!=null){
            userInfoContext.emailAddress=value;
        }
    }

    const setPassword=(value:string)=>{
        if(userInfoContext!=null){
            userInfoContext.password=value;
            userInfoContext.confirmPassword=value
        }
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
            <AppInputField
                isEmail={true}
                value={userInfoContext?.emailAddress}
                showCharacterCounter={false}
                onChange={setEmailAddress}
                maxValueCounter={255}
                errorMsg={errorEmail}
                containerStyle={styles.inputEmailContainer}
                textStyle={styles.input}
                placeholder={'email'}
                isErrorAlignCenter={true}
                autoFocus={true}
            />
            <AppInputField
                value={userInfoContext?.password}
                secureTextEntry={true}
                showCharacterCounter={false}
                onChange={setPassword}
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
