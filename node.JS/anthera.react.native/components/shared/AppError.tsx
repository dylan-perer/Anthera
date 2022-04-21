import * as Animatable from "react-native-animatable";
import {StyleSheet, Text, ViewStyle} from "react-native";
import {AntheraStyle, isPhoneScreen, scale} from "../../styles/AntheraStyle";

type InlineErrorProps = {
    style?: ViewStyle,
    errorMsg: string | undefined,
}
const AppError = (props: InlineErrorProps) => {
    if (props.errorMsg)
        return <Animatable.Text
            animation={"fadeIn"}
            duration={1000}
            style={[styles.errorText, props.style]}>{props.errorMsg}
        </Animatable.Text>

    return <Text style={[styles.errorText, {opacity:0}]}>reserved error space</Text>
}

const styles = StyleSheet.create({
    errorAndCounterContainer: {},
    errorText: {
        fontFamily: AntheraStyle.font.nuntito_SemiBold,
        fontSize: isPhoneScreen ? scale(11.5) : scale(7.5),
        color: AntheraStyle.colour.error,
    }
});

export default AppError;
