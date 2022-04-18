import {
    Keyboard,
    KeyboardAvoidingView,
    Platform, SafeAreaView,
    ScrollView,
    StyleSheet,
    Text,
    TouchableOpacity,
    TouchableWithoutFeedback,
    View, ViewStyle
} from "react-native";
import {UserInfoScreens} from "../signup/SignupNavigator";
import {
    AntheraStyle,
    isPhoneScreen,
    isSmallPhoneScreen,
    moderateScale,
    scale,
    screen, screenDeviation,
    verticalScale
} from "../../styles/AntheraStyle";
import * as Animatable from 'react-native-animatable';
import BackIcon from "../../assets/svgs/BackIcon";
import CustomIcon from "../shared/CustomIcon";
import InputField from "../shared/InputField";
import {Formik} from "formik";
import {useState} from "react";
import AppButton from "../shared/AppButton";

export type UserInfoProps={
    tilePrefix:string,
    titleHighLighted: string,
    titlePostfix:string,
    titleHighLightedEnd?:string,
    hint?:string,
    children?: JSX.Element,
    onContinue: ()=>void,
    onGoBack: ()=>void,
    isContinueDisabled?:boolean,
    btnStyle?:ViewStyle
}

const UserInfo = (props:UserInfoProps)=>{

    return  <SafeAreaView>
    <ScrollView
                style={styles.container}
                keyboardShouldPersistTaps='always'>
                 <CustomIcon
                     styleContainer={{marginTop:isSmallPhoneScreen? verticalScale(24):isPhoneScreen? verticalScale(32):verticalScale(30)}}
                     onPress={props.onGoBack}
                     Svg={<BackIcon {...styles.backIcon}/>}
                 />

                <View style={styles.titleWrapper}>
                    <Animatable.Text style={styles.titleContainer} animation={'fadeIn'} duration={2000}>
                        <Text style={styles.title}>{props.tilePrefix}</Text>
                        <Text style={[styles.title, {color:AntheraStyle.colour.main}]}>{props.titleHighLighted}</Text>
                        <Text style={styles.title}>{props.titlePostfix}</Text>
                        <Text style={[styles.title, {color:AntheraStyle.colour.main}]}>{props.titleHighLightedEnd}</Text>
                    </Animatable.Text>

                    {props.hint && <Animatable.Text style={styles.hintText} animation={'fadeIn'} delay={500} duration={2000} >{props.hint}</Animatable.Text>}
                </View>

                {props.children}

                <View style={{flexDirection:'row', justifyContent:'center', marginVertical:screenDeviation(35,80,80)}}>
                <AppButton
                    width={{smallScreen:250,phoneScreen:250,largeScreen:250}}
                    height={{smallScreen:55, phoneScreen:45, largeScreen:50}}

                    text={'Continue'}

                    shadowPos_X={0}
                    shadowPos_Y={screenDeviation(5,5,5)}

                    btnStyle={{backgroundColor:AntheraStyle.colour.main, alignSelf:'center'}}
                    textStyle={{color:'#fff'}}

                    onPress={props.onContinue}/>
                </View>
    </ScrollView>
    </SafeAreaView>
}



const styles = StyleSheet.create({
    container: {
    },
    backIcon:{
        width:isSmallPhoneScreen? verticalScale(26):isPhoneScreen? verticalScale(24):verticalScale(26),
        height:isSmallPhoneScreen? verticalScale(26):isPhoneScreen? verticalScale(24):verticalScale(26),
    },
    titleWrapper:{
        marginTop:isSmallPhoneScreen? verticalScale(1):isPhoneScreen? verticalScale(10):verticalScale(20),
        marginHorizontal:verticalScale(20),
        alignSelf:'center',
        marginBottom:isSmallPhoneScreen? verticalScale(8):isPhoneScreen? verticalScale(28):verticalScale(30),
    },
    titleContainer:{
        flexDirection:'row'
    },
    title:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.headerMedium,
    },
    hintText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        color:AntheraStyle.colour.TextGreyLight,
        fontSize:AntheraStyle.font.size.textVerySmall,
        marginTop:verticalScale(5),
        alignSelf:'flex-start',
    },
    continueBtn:{
        borderRadius:moderateScale(30),
        backgroundColor:AntheraStyle.colour.main,
        width:moderateScale(250),
        height:screenDeviation(55,45,50),
        justifyContent:'center',
        alignItems:'center',
        alignSelf:'center',
        marginTop: screenDeviation(35,80,80)
    },
    continueBtnText:{
        color: '#fff',
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:moderateScale(20)
    },
});

export default UserInfo;
