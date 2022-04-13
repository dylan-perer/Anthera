import { Dimensions } from 'react-native';
const { width, height } = Dimensions.get('window');

//Guideline sizes are based on standard ~5" screen mobile device
const guidelineBaseWidth = 350;
const guidelineBaseHeight = 680;

const scale = (size:number) => width / guidelineBaseWidth * size;
const verticalScale = (size:number) => height / guidelineBaseHeight * size;
const moderateScale = (size:number, factor:number = 0.5) => size + ( scale(size) - size ) * factor;
const isPhoneScreen = width <= 550?true:false;

const AntheraStyle = {
    font : {
        questrial: "Questrial-Regular",
        nuntito_SemiBold: "Nunito-SemiBold",
        nunito_regular: "Nunito-Regular",
        size:{
            header: isPhoneScreen? scale(20): scale(13)
        }
    },
    colour:{
        main: "#F4AEA4",
        Secondary: "#FBD3CD",
        dark: '#C28C84',
        TextGrey: "#545454",
        BackgroundGrey: "#FFF"
    }
}


const screen={
    width:width,
    height:height,
}


export {AntheraStyle, screen, scale, verticalScale, moderateScale, isPhoneScreen}
