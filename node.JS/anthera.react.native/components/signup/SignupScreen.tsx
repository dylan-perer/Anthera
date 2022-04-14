import {StyleSheet, Text, TouchableOpacity, View} from "react-native";
import LogoWithName from "../../assets/svgs/LogoWithName";
import * as Animatable from 'react-native-animatable';
import {AntheraStyle, moderateScale, scale, screen, verticalScale} from "../../styles/AntheraStyle";
import {UserInfoScreens} from "./SignupNavigator";

const SignupScreen =({navigation}: {navigation: any})=>{

    const onGenderPress = (screenName: UserInfoScreens)=>{
        navigation.navigate(screenName)
    }

    return <View style={styles.container}>

        <Animatable.View animation={"fadeIn"} duration={2000}>
            <LogoWithName {...styles.logo} />
        </Animatable.View>

        <View style={styles.textContainer}>
            <Animatable.Text animation={'fadeIn'} duration={6000} style={[styles.text, {marginRight:moderateScale(100)}]}>Hello there,</Animatable.Text>
            <Animatable.Text animation={'fadeIn'} duration={6000} delay={2000} style={[styles.text, {marginLeft:moderateScale(100)}]}>Lets get you sorted.</Animatable.Text>
        </View>


        <Animatable.View animation={'fadeIn'} duration={2000} delay={4000}>
            <View style={styles.btnContainer}>
                <TouchableOpacity style={styles.btn} onPress={()=>onGenderPress('NameScreen')}>
                    <Text style={styles.btnText}>Female</Text>
                </TouchableOpacity>
                <TouchableOpacity style={styles.btn} onPress={()=>onGenderPress('NameScreen')}>
                    <Text style={styles.btnText}>Male</Text>
                </TouchableOpacity>
            </View>
        </Animatable.View>

        <TouchableOpacity style={styles.moreChoicesBtn}>
            <Animatable.Text animation={"fadeIn"} duration={2000} delay={4500} style={styles.moreChoicesText}>More choices</Animatable.Text>
        </TouchableOpacity>


    </View>
}



const styles = StyleSheet.create({
    container:{
        flex:1,
        marginVertical:verticalScale(80)
    },
    logo:{
        alignSelf:'center',
        width:moderateScale(165),
        height:verticalScale(165),
    },
    textContainer:{
        width:screen.width,
        flexDirection:'column',
        alignItems:'center',
        justifyContent:'center'
    },
    text:{
        fontFamily:AntheraStyle.font.nunito_regular,
        fontSize:AntheraStyle.font.size.header
    },
    btnContainer: {
        width:screen.width,
        flexDirection:'row',
        alignItems:'center',
        justifyContent:'center',
        marginTop:verticalScale(60),
    },
    btn:{
        borderWidth:1.5,
        borderColor:AntheraStyle.colour.bright,
        borderRadius: moderateScale(30),
        width:moderateScale(130),
        marginHorizontal:moderateScale(5)
    },
    btnText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.headerSmall,
        paddingVertical:moderateScale(7),
        alignSelf:'center',
        color:AntheraStyle.colour.main
    },
    moreChoicesBtn:{
        marginTop:verticalScale(20),
        alignItems:'center'
    },
    moreChoicesText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.headerSmall,
        color:AntheraStyle.colour.main
    }
});

export default SignupScreen;
