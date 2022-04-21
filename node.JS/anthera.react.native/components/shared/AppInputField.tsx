import {StyleSheet, Text, TextInput, TextInputProps, View, ViewStyle} from "react-native";
import {AntheraStyle, moderateScale} from "../../styles/AntheraStyle";
import {useRef, useState} from "react";
import AppError from "./AppError";

export type InputFieldProps = {
    textAlign?: any,
    placeholder?: string,
    containerStyle?: ViewStyle,
    textStyle?: ViewStyle,
    counterStyle?: ViewStyle,
    showCharacterCounter: boolean,
    maxValueCounter: number,
    errorMsg: string,
    onChange?: any
    isErrorAlignCenter?: boolean
    autoFocus?: boolean,
    secureTextEntry?: boolean,
    isAutoCorrect?: boolean,
    isEmail?:boolean,
    value?: string,
    capitalize?:boolean
}

const AppInputField = (props: InputFieldProps) => {
    const characterCounter = useRef(0);
    const [currentText, setCurrentText] = useState(props.value?props.value:'');

    const onChangeText = (text: string) => {
        setCurrentText(text);
        props.onChange(text);
        characterCounter.current = text.length;
    }
    return <View style={[styles.inputWrapper, props.containerStyle]}>
        <TextInput
            defaultValue={props.value?props.value:undefined}
            secureTextEntry={props.secureTextEntry}
            value={currentText}
            maxLength={props.maxValueCounter}
            onChangeText={(text) => onChangeText(text)}
            style={[styles.input, props.textStyle]}
            textAlign={props.textAlign ? props.textAlign : 'center'}
            placeholder={props.placeholder ? props.placeholder : 'Jane'}
            autoFocus={props.autoFocus}
            keyboardType={props.isEmail?"email-address":props.isAutoCorrect?undefined:"visible-password"}
            autoCapitalize={props.capitalize?'sentences':'none'}
        />
        <View style={[styles.errorAndCounterContainer, props.isErrorAlignCenter ? {justifyContent: 'center'} : {}]}>
            {props.showCharacterCounter && <Text style={[styles.letterCount, props.counterStyle]}>
                {characterCounter.current}/{props.maxValueCounter} </Text>}

            <AppError errorMsg={props.errorMsg}/>
        </View>

    </View>
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
    input: {
        borderBottomWidth: 1,
        paddingTop: moderateScale(10),
        borderColor: AntheraStyle.colour.TextGrey,
        fontSize: moderateScale(16.5),
        width: '100%',
    },
    errorAndCounterContainer: {
        flexDirection: 'row',
        justifyContent: 'space-between',
        width: '100%'
    },
    letterCount: {
        alignSelf: 'flex-end',
        fontFamily: AntheraStyle.font.nuntito_SemiBold,
        color: AntheraStyle.colour.TextGreyLight,
        fontSize: moderateScale(10.5)
    },
    inputWrapper: {
        alignSelf: 'center',
        flexDirection: 'column',
        justifyContent: 'center',
        alignItems: 'center',
        width: moderateScale(300),
    },
    errorText: {
        fontFamily: AntheraStyle.font.nuntito_SemiBold,
        fontSize: moderateScale(12),
        color: AntheraStyle.colour.error,
    }
});


export default AppInputField;
