import {StyleSheet, Text, TextInput, View} from "react-native";
import UserInfo from "./UserInfo";
import {
    AntheraStyle,
    isPhoneScreen,
    moderateScale,
    scale,
    screenDeviation,
    verticalScale
} from "../../styles/AntheraStyle";
import {useContext, useRef, useState} from "react";
import AppRadioBtn from "../../components/shared/AppRadioBtn";
import Coffee from "../../assets/svgs/Coffee";
import Heart from "../../assets/svgs/heart";
import Chat from "../../assets/svgs/Chat";
import {SignupRequest} from "../../api/AntheraApi";
import {NativeStackScreenProps} from "@react-navigation/native-stack";
import {StackParamList} from "../../components/navigators/SignupNavigator";
import {UserInfoContext} from "../../contexts/UserInfoContext";

const HeretoScreen = ({route, navigation}:NativeStackScreenProps<StackParamList, 'HeretoScreen'>)=>{
    const hereToOptions = {
        date: 'I\'m here to date',
        chat: 'I\'m here to chat',
        relationship: 'I\'m ready for an relationship'
    }

    const userInfoContext = useContext(UserInfoContext);

    const [radioBtn1, setRadioBtn1] = useState(userInfoContext?.hereTo==hereToOptions.date?true:false);
    const [radioBtn2, setRadioBtn2] = useState(userInfoContext?.hereTo==hereToOptions.chat?true:false);
    const [radioBtn3, setRadioBtn3] = useState(userInfoContext?.hereTo==hereToOptions.relationship?true:false);


    const onContinue=()=> {
        if(userInfoContext!=null){
            navigation.navigate('SexPreferenceScreen');

        }
    }
    const onPress=(val:string,state:any)=>{
        if(userInfoContext!=null)
        {
            userInfoContext.hereTo=val;

            setRadioBtn1(false);
            setRadioBtn2(false);
            setRadioBtn3(false);

            state(true)
        }
    }
    return (
        <UserInfo
            tilePrefix={'You are '}
            titleHighLighted={'here '}
            titlePostfix={'to?'}
            hint={'This can always be changed later!'}
            onGoBack={()=>{navigation.navigate('DobScreen')}}
            onContinue={onContinue}
        >
            <View style={[{alignSelf:'center'},{marginTop: screenDeviation(20,0,0)}]}>
                <AppRadioBtn style={styles.radioBtnContainer}
                             setSelected={setRadioBtn1}
                             value={hereToOptions.date}
                             onPress={(val)=>{onPress(val,setRadioBtn1)}}
                             isSelected={radioBtn1}>
                    <View style={styles.itemContainer}>
                        <View style={styles.textWrapper}>
                            <Text style={styles.subHeader}>I'm here to date</Text>
                            <Text style={styles.details}>Go on dates and have good time.</Text>
                        </View>
                        <Coffee {...styles.svg}/>
                    </View>
                </AppRadioBtn>
                <AppRadioBtn style={styles.radioBtnContainer}
                             setSelected={setRadioBtn2}
                             value={hereToOptions.chat}
                             onPress={(val)=>{onPress(val,setRadioBtn2)}}
                             isSelected={radioBtn2}>
                    <View style={styles.itemContainer}>
                        <View style={styles.textWrapper}>
                            <Text style={styles.subHeader}>I'm here to chat</Text>
                            <Text style={styles.details}>Here to meet new people.</Text>
                        </View>
                        <Chat {...styles.svg}/>
                    </View>
                </AppRadioBtn>
                <AppRadioBtn style={styles.radioBtnContainer}
                             setSelected={setRadioBtn3}
                             value={hereToOptions.relationship}
                             onPress={(val)=>{onPress(val,setRadioBtn3)}}
                             isSelected={radioBtn3}>
                    <View style={styles.itemContainer}>
                        <View style={styles.textWrapper}>
                            <Text style={styles.subHeader}>I'm ready for an relationship</Text>
                            <Text style={styles.details}>Ready for an serious relationship.</Text>
                        </View>
                        <Heart {...styles.svg}/>
                    </View>
                </AppRadioBtn>
            </View>
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
    radioBtnContainer:{
        borderRadius:moderateScale(12),
        borderWidth:moderateScale(1),
        borderColor:AntheraStyle.colour.accent,
        paddingHorizontal:moderateScale(10),
        paddingVertical:moderateScale(12),
        marginBottom:moderateScale(10)
    },
    itemContainer:{
        flexDirection:'row',
        width: isPhoneScreen? moderateScale(280):moderateScale(200),
        justifyContent:'space-between',
        alignItems:'center'
    },
    textWrapper:{

    },
    subHeader:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.subHeader
    },
    details:{
        fontFamily:AntheraStyle.font.nunito_regular,
        color:AntheraStyle.colour.TextGreyLight,
        fontSize:AntheraStyle.font.size.textVerySmall
    },
    svg:{
        width: isPhoneScreen?moderateScale(25):moderateScale(20),
        height:isPhoneScreen?moderateScale(25):moderateScale(20),
    }
});

export default HeretoScreen;
