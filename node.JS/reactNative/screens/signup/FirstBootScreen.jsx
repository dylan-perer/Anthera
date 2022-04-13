import { StyleSheet, Text, View } from 'react-native'
import Decoration  from '../../assets/svgs/profile.creation.startup.decoration';
import Logo  from '../../assets/svgs/logo';
import {scale, screen, verticalScale, moderateScale,isPhoneScreen} from '../../misc/Anthera.Dimension'
import React from 'react'
import * as Animatable from 'react-native-animatable';
import {AntheraStyle}  from '../../Styles/AntheraStyles';
import { TouchableOpacity } from 'react-native-gesture-handler';


const FirstBootScreen = ({navigation}) => {
  return (
    <TouchableOpacity onPress={()=>transistion(navigation,0)}>
        <Animatable.View {...decorationAnim} onAnimationEnd={()=>transistion(navigation,2000)}>
            <Decoration {...styles.decoration}/>
        </Animatable.View>
        <Animatable.View {...logoAnim} style={{top:verticalScale(-220)}}>
            <Logo {...styles.logo}/>
            <Text style={styles.logoText}>anthera</Text>
        </Animatable.View>
        <View style={styles.TextWrapper}>
            <Animatable.Text {...TextAnim}>
                <Text style={[styles.Text,{color:AntheraStyle.colour.MainBlue}]}>Hello <Text style={{color:AntheraStyle.colour.TextGrey}}>there,</Text></Text>
            </Animatable.Text>
            <Animatable.Text {...TextAnim} duration={TextAnim.durationSecond}><Text style={styles.Text}>Lets get you sorted.</Text></Animatable.Text>
        </View>
    </TouchableOpacity>
  )
}
const transistion = (navigation, time) =>{
    setTimeout(()=>{navigation.navigate('GenderScreen')},time);
}
const decorationAnim = {
    animation:{
        0: {
            left: isPhoneScreen?-moderateScale(400):-moderateScale(400),
            top: isPhoneScreen?-moderateScale(350):-moderateScale(300),
        },
        1: {
            left: isPhoneScreen?-moderateScale(190):-moderateScale(220),
            top: isPhoneScreen?-moderateScale(130):-moderateScale(85),
        },
    },
    duration:3000
  };

  const logoAnim = {
    animation:{
        0: {
           opacity: 0
        },
        1: {
            opacity: 1
        },
    },
    duration:4000
  };

  const TextAnim = {
    animation:{
        0: {
           opacity: 0
        },
        1: {
            opacity: 1
        },
    },
    duration:4000,
    durationSecond:8000,
  };

export default FirstBootScreen

const styles = StyleSheet.create({
    decoration:{
        height:verticalScale(400),
        width: moderateScale(400),
    },
    logo:{
        height:verticalScale(70),
        width: moderateScale(70),
        flex:1,
        flexDirection:'row',
        backgroundColor:'red',
        alignSelf: 'center',
    },
    logoText:{
        fontFamily: AntheraStyle.font.Questrial,
        fontSize: moderateScale(34),
        color:AntheraStyle.colour.MainBlue,   
        alignSelf: 'center',  
    },
    TextWrapper:{
        marginRight:20, 
        alignItems:'flex-end', 
        left: isPhoneScreen? moderateScale(-20): moderateScale(10),
        bottom:verticalScale(40)
    },
    Text:{
        fontFamily: AntheraStyle.font.Questrial,
        fontSize: AntheraStyle.font.size.header,
        color:AntheraStyle.colour.TextGrey,        
    }
})