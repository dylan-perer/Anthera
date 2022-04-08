import { StyleSheet, Text, View } from 'react-native'
import Decoration  from '../assets/svgs/profile.creation.startup.decoration';
import Logo  from '../assets/svgs/logo';
import {scale, screen, verticalScale, moderateScale,isPhoneScreen} from '../misc/Anthera.Dimension'
import React from 'react'
import * as Animatable from 'react-native-animatable';
import {Style}  from '../Constants/AntheraStyles';

const FirstBootScreen = () => {
  return (
    <View>
        <Animatable.View {...decorationAnim}>
            <Decoration {...styles.decoration}/>
        </Animatable.View>
        <Animatable.View {...logoAnim} style={{top:verticalScale(-220)}}>
            <Logo {...styles.logo}/>
            <Text style={styles.logoText}>anthera</Text>
        </Animatable.View>
        <View style={styles.TextWrapper}>
            <Animatable.Text {...TextAnim}><Text style={[styles.Text,{color:Style.colour.MainBlue}]}>Hello <Text style={{color:Style.colour.TextGrey}}>there,</Text></Text></Animatable.Text>
            <Animatable.Text {...TextAnim} duration={TextAnim.durationSecond}><Text style={styles.Text}>Lets get you sorted.</Text></Animatable.Text>
        </View>
    </View>
  )
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
    duration:4000
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
        fontFamily: Style.font.Questrial,
        fontSize: moderateScale(34),
        color:Style.colour.MainBlue,   
        alignSelf: 'center',  
    },
    TextWrapper:{
        marginRight:20, 
        alignItems:'flex-end', 
        left: isPhoneScreen? moderateScale(-20): moderateScale(10),
        bottom:verticalScale(40)
    },
    Text:{
        fontFamily: Style.font.Questrial,
        fontSize: moderateScale(22),
        color:Style.colour.TextGrey,        
    }
})