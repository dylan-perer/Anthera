import {StyleSheet} from "react-native";
import UserInfo from "./UserInfo";
import {
    screenDeviation,
} from "../../styles/AntheraStyle";
import AppInputField from "../../components/shared/AppInputField";
import {useContext, useRef, useState} from "react";
import {StackParamList} from "../../components/navigators/SignupNavigator";
import {NativeStackScreenProps} from "@react-navigation/native-stack";
import {UserInfoContext} from "../../contexts/UserInfoContext";

const NameScreen = ({route, navigation}:NativeStackScreenProps<StackParamList, 'NameScreen'>)=>{
    const [error, setError] = useState('');
    const userInfoContext = useContext(UserInfoContext);

    const onContinue=()=>{
        setError('');
        if(userInfoContext?.name!=undefined){
            if(userInfoContext?.name.length > 1){
                console.log(userInfoContext.gender)
                navigation.navigate('DobScreen');
            }else{
                setError('Sorry, name is too short.');
            }
        }

    }
    const setName =(value:string)=>{
        if(userInfoContext!=null){
            userInfoContext.name = value
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
            <AppInputField
                value={userInfoContext?.name?userInfoContext.name:undefined}
                showCharacterCounter={true}
                maxValueCounter={14}
                errorMsg={error}
                onChange={setName}
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
