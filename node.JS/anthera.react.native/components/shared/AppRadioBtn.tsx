import {StyleSheet, TouchableOpacity, View, ViewStyle} from "react-native";
import {AntheraStyle, moderateScale} from "../../styles/AntheraStyle";
import * as Animatable from 'react-native-animatable';
import {bool} from "yup";

type RadioBtnProps = {
    children: JSX.Element,
    style?: ViewStyle,
    value: string,
    onPress: (value: string) => void,
    isSelected?: boolean,
    setSelected: any,
    default?:boolean;
}
const AppRadioBtn = (props: RadioBtnProps) => {
    return <TouchableOpacity style={[styles.container, props.style]} onPress={() => {

        if (!props.isSelected) {
            props.onPress(props.value);
        } else {
            props.onPress('');
        }

    }}>
        <View style={styles.btnContainer}>
            {props.isSelected &&
                <Animatable.View animation={"fadeIn"} duration={1000} style={styles.selectCircle}></Animatable.View>}
        </View>
        {props.children}
    </TouchableOpacity>
}

const styles = StyleSheet.create({
    container: {
        flexDirection: 'row',
        alignItems: 'center'
    },
    btnContainer: {
        width: moderateScale(22),
        height: moderateScale(22),
        borderRadius: moderateScale(40),
        borderWidth: moderateScale(1.5),
        borderColor: AntheraStyle.colour.main,
        alignItems: 'center',
        justifyContent: 'center',
        marginRight: moderateScale(10)
    },
    selectCircle: {
        backgroundColor: AntheraStyle.colour.main,
        width: moderateScale(12),
        height: moderateScale(12),
        alignSelf:'center',
        borderRadius: moderateScale(60),
    }
});
export default AppRadioBtn;
