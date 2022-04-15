import {
    Keyboard,
    KeyboardAvoidingView,
    Platform,
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
    screen,
    verticalScale
} from "../../styles/AntheraStyle";
import * as Animatable from 'react-native-animatable';
import BackIcon from "../../assets/svgs/BackIcon";
import CustomIcon from "../shared/CustomIcon";
import InputField from "../shared/InputField";
import {Formik} from "formik";
import {useState} from "react";

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

    return  <ScrollView
                style={styles.container}
                keyboardShouldPersistTaps='always'>
                 <CustomIcon styleContainer={{marginTop:verticalScale(50)}} onPress={props.onGoBack}  Svg={<BackIcon {...styles.backIcon}/>}/>

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

                <TouchableOpacity disabled={props.isContinueDisabled} onPress={props.onContinue} style={[styles.continueBtn,props.btnStyle]}>
                    <Text style={styles.continueBtnText}>Continue</Text>
                </TouchableOpacity>

    </ScrollView>
}



const styles = StyleSheet.create({
    container: {
    },
    backIcon:{
        width:isSmallPhoneScreen? verticalScale(24):isPhoneScreen? verticalScale(28):verticalScale(30),
        height:isSmallPhoneScreen? verticalScale(24):isPhoneScreen? verticalScale(28):verticalScale(30),
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
        fontSize:AntheraStyle.font.size.header,
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
        height:verticalScale(45),
        justifyContent:'center',
        alignItems:'center',
        alignSelf:'center',
        marginTop: isSmallPhoneScreen? verticalScale(35):verticalScale(80)
    },
    continueBtnText:{
        color: '#fff',
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:moderateScale(20)
    },
});

export default UserInfo;
