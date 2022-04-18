import { Dimensions, Platform } from 'react-native';
import calculateColorContrast from "../misc/ColorCalcuator";
const { width, height } = Dimensions.get('window');

//Guideline sizes are based on standard ~5" screen mobile device
const guidelineBaseWidth = 350;
const guidelineBaseHeight = 680;

const scale = (size:number) => width / guidelineBaseWidth * size;
const verticalScale = (size:number) => height / guidelineBaseHeight * size;
const moderateScale = (size:number, factor:number = 0.5) => size + ( scale(size) - size ) * factor;
const isPhoneScreen = width <= 550?true:false;
const isSmallPhoneScreen = height<=600?true:false;
const screenDeviation=(onSmallPhoneScreen:number, onPhoneScreen:number, onLargeScreen:number)=>{
    return isSmallPhoneScreen? verticalScale(onSmallPhoneScreen):isPhoneScreen? verticalScale(onPhoneScreen):verticalScale(onLargeScreen);
}
const onPlatform = (ios:number, android:number)=>{
    return Platform.OS === 'ios'? ios: android
}
let mainColor = '#F4AEA4';
const AntheraStyle = {
    font : {
        questrial: "Questrial-Regular",
        nuntito_SemiBold: "Nunito-SemiBold",
        nunito_regular: "Nunito-Regular",
        size:{
            header: isPhoneScreen? scale(21): scale(13),
            headerMedium: isPhoneScreen? scale(18.5): scale(13),
            headerSmall: isPhoneScreen? scale(18): scale(11),
            textMedium: isPhoneScreen? scale(17): scale(10),
            subHeader: isPhoneScreen? scale(15.5): scale(9),
            textSmall: isPhoneScreen? scale(14): scale(8),
            textVerySmall: isPhoneScreen? scale(13): scale(7.5),
        }
    },
    colour:{
        main: "#2170FC",
        // main: "#1778F2",
        Secondary: "#D4E3FF",
        accent:'#FFB4F3',
        dark: '#1C58C4',
        mid:'#649CFF',
        veryLightGrey:'#ebebeb',
        light:'#E0D7FC',
        // main: mainColor,
        // Secondary: calculateColorContrast(mainColor, -10),
        // dark: calculateColorContrast(mainColor, +10),
        IconGrey:'#7C7C7C',
        IconGreyLight:'#CCCCCC',
        TextGrey: "#545454",
        TextGreyLight:"#6E6E6E",
        TextGreyVeryLight:'#949494',
        BackgroundGrey:'#fff',// "#F3F3F3",
        error:'#ff5050',
        bright:'#FC8C7D'
    }
}


const screen={
    width:width,
    height:height,
}


export {AntheraStyle, screen, scale, verticalScale, moderateScale, isPhoneScreen, isSmallPhoneScreen,screenDeviation,onPlatform}
