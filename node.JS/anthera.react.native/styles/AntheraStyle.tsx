import { Dimensions } from 'react-native';
const { width, height } = Dimensions.get('window');

//Guideline sizes are based on standard ~5" screen mobile device
const guidelineBaseWidth = 350;
const guidelineBaseHeight = 680;

const scale = (size:number) => width / guidelineBaseWidth * size;
const verticalScale = (size:number) => height / guidelineBaseHeight * size;
const moderateScale = (size:number, factor:number = 0.5) => size + ( scale(size) - size ) * factor;
const isPhoneScreen = width <= 550?true:false;
const isSmallPhoneScreen = width <=200?true:false;

const AntheraStyle = {
    font : {
        questrial: "Questrial-Regular",
        nuntito_SemiBold: "Nunito-SemiBold",
        nunito_regular: "Nunito-Regular",
        size:{
            header: isPhoneScreen? scale(21): scale(13),
            headerSmall: isPhoneScreen? scale(18): scale(11),
            textMedium: isPhoneScreen? scale(15): scale(10),
        }
    },
    colour:{
        main: "#F4AEA4",
        Secondary: "#FBD3CD",
        dark: '#C28C84',
        TextGrey: "#545454",
        TextGreyLight:"#6E6E6E",
        BackgroundGrey: "#FFF",
        error:'#ff5050',
        bright:'#F6998C'
    }
}


const screen={
    width:width,
    height:height,
}


export {AntheraStyle, screen, scale, verticalScale, moderateScale, isPhoneScreen, isSmallPhoneScreen}
