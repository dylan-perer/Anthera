import { Dimensions } from 'react-native';
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

let mainColor = '#F4AEA4';
const AntheraStyle = {
    font : {
        questrial: "Questrial-Regular",
        nuntito_SemiBold: "Nunito-SemiBold",
        nunito_regular: "Nunito-Regular",
        size:{
            header: isPhoneScreen? scale(21): scale(13),
            headerSmall: isPhoneScreen? scale(18): scale(11),
            textMedium: isPhoneScreen? scale(17): scale(10),
            subHeader: isPhoneScreen? scale(15.5): scale(9),
            textSmall: isPhoneScreen? scale(14): scale(8),
            textVerySmall: isPhoneScreen? scale(13.5): scale(7.5),
        }
    },
    colour:{
        main: "#F39D93",
        Secondary: "#FBD3CD",
        dark: '#C28C84',
        // main: mainColor,
        // Secondary: calculateColorContrast(mainColor, -10),
        // dark: calculateColorContrast(mainColor, +10),
        TextGrey: "#545454",
        TextGreyLight:"#6E6E6E",
        BackgroundGrey:'#fff',// "#F3F3F3",
        error:'#ff5050',
        bright:'#FC8C7D'
    }
}


const screen={
    width:width,
    height:height,
}


export {AntheraStyle, screen, scale, verticalScale, moderateScale, isPhoneScreen, isSmallPhoneScreen}
