import {StyleSheet, Text, TouchableOpacity, View, ViewStyle} from "react-native";
import {AntheraStyle, moderateScale} from "../../styles/AntheraStyle";

export type CustomIconProps = {
    Svg: JSX.Element,
    onPress: () => any,
    styleContainer?: ViewStyle,
    label?:string
}

const AppSvgIcon = (props: CustomIconProps) => {
    return <TouchableOpacity onPress={props.onPress} style={[styles.touchable, props.styleContainer]}>
        <View style={{flexDirection:'column', width:200, justifyContent:"center", alignItems:'center',alignContent:'center'}}>
            {props.Svg}
            {props.label && <Text style={styles.label}>{props.label}</Text>}
        </View>
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
    label:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.textVerySmall,
        justifyContent:'center',
        color:AntheraStyle.colour.TextGrey
    }
});

export default AppSvgIcon;
