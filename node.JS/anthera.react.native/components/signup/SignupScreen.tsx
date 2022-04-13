import {StyleSheet, Text, TouchableOpacity, View} from "react-native";
import Logo from "../../assets/svgs/Logo";
import * as Animatable from 'react-native-animatable';
import {AntheraStyle, moderateScale, screen, verticalScale} from "../../styles/AntheraStyle";
import {UserInfoScreens} from "./SignupNavigator";

const SignupScreen =({navigation}: {navigation: any})=>{

    const onGenderPress = (screenName: UserInfoScreens)=>{
        navigation.navigate(screenName)
    }

    return <View style={styles.container}>

        <Animatable.View>
            <Logo {...styles.logo} />
        </Animatable.View>

        <View style={styles.textContainer}>
            <Animatable.Text style={[styles.text, {marginRight:moderateScale(100)}]}>Hello there,</Animatable.Text>
            <Animatable.Text style={[styles.text, {marginLeft:moderateScale(100)}]}>Lets get you sorted.</Animatable.Text>
        </View>


        <Animatable.View>
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
            <Text style={styles.moreChoicesText}>More choices</Text>
        </TouchableOpacity>

    </View>
}

const styles = StyleSheet.create({
    container:{
        flex:1,
        marginVertical:verticalScale(100)
    },
    logo:{
        alignSelf:'center',
        width:moderateScale(80),
        height:verticalScale(80),
    },
    textContainer:{
        width:screen.width,
        flexDirection:'column',
        alignItems:'center',
        justifyContent:'center'
    },
    text:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.header
    },
    btnContainer: {
        width:screen.width,
        flexDirection:'row',
        alignItems:'center',
        justifyContent:'center'
    },
    btn:{
        borderWidth:1.5,
        borderColor:AntheraStyle.colour.main,
        borderRadius: moderateScale(30),
        width:moderateScale(100)
    },
    btnText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.header,
        paddingVertical:moderateScale(6),
        alignSelf:'center'
    },
    moreChoicesBtn:{
        alignItems:'center'
    },
    moreChoicesText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:moderateScale(20),
        color:AntheraStyle.colour.main
    }
});

export default SignupScreen;
