import {StyleSheet, TouchableOpacity, ViewStyle} from "react-native";
import {moderateScale} from "../../styles/AntheraStyle";

export type CustomIconProps = {
    Svg: JSX.Element,
    onPress: () => any,
    styleContainer: ViewStyle,
}

const AppSvgIcon = (props: CustomIconProps) => {
    return <TouchableOpacity onPress={props.onPress} style={[styles.touchable, props.styleContainer]}>
        {props.Svg}
    </TouchableOpacity>
}

const styles = StyleSheet.create({
    touchable: {
        width: moderateScale(50),
        height: moderateScale(50),
        borderRadius: moderateScale(40),
        alignItems: 'center',
        justifyContent: 'center'
    },
});

export default AppSvgIcon;
