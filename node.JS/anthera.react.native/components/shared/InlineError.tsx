import * as Animatable from "react-native-animatable";
import {StyleSheet, ViewStyle} from "react-native";
import {AntheraStyle, moderateScale, isPhoneScreen, scale} from "../../styles/AntheraStyle";

type InlineErrorProps = {
    style?:ViewStyle,
    errorMsg: string,
}
const InlineError = (props:InlineErrorProps)=>{
    return <Animatable.Text animation={"shake"}  duration={2000} style={[styles.errorText, props.style]}>{props.errorMsg}</Animatable.Text>
}

const styles = StyleSheet.create({
    errorAndCounterContainer:{},
    errorText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize: isPhoneScreen? scale(11.5): scale(7.5),
        color: AntheraStyle.colour.error,
    }
});

export default InlineError;
