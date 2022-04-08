import { Dimensions } from 'react-native';
const { width, height } = Dimensions.get('window');

//Guideline sizes are based on standard ~5" screen mobile device
const guidelineBaseWidth = 350;
const guidelineBaseHeight = 680;

const scale = (size:number) => width / guidelineBaseWidth * size;
const verticalScale = (size:number) => height / guidelineBaseHeight * size;
const moderateScale = (size:number, factor:number = 0.5) => size + ( scale(size) - size ) * factor;
const isPhoneScreen = width <= 550?true:false;

const screen={
    width:width,
    height:height,
}
export {scale, verticalScale, moderateScale ,  screen,isPhoneScreen};