import {screen, scale, verticalScale, moderateScale, isPhoneScreen} from '../misc/Anthera.Dimension'
const AntheraStyle = {
    font : {
        Questrial: "Questrial-Regular",
        size:{
            header: isPhoneScreen? scale(20): scale(13)
        }
    },
    colour:{
        MainBlue: "#2170FC",
        SecondaryBlue: "#CFDFF7",
        borderBlue: '#85B4FC',
        TextGrey: "#545454",
        BackgroundGrey: "#FFF"
    }
}



export {AntheraStyle, screen, scale, verticalScale, moderateScale, isPhoneScreen}