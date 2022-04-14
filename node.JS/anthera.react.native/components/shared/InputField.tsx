import {StyleSheet, Text, TextInput, View, ViewStyle} from "react-native";
import {AntheraStyle, moderateScale} from "../../styles/AntheraStyle";
import {useRef, useState} from "react";
import * as Animatable from 'react-native-animatable';
import InlineError from "./InlineError";

export type InputFieldProps = {
    textAlign?: any,
    placeholder?:string,
    containerStyle?:ViewStyle,
    textStyle?: ViewStyle,
    counterStyle?:ViewStyle,
    showCharacterCounter:boolean,
    maxValueCounter:number,
    errorMsg:string,
    onChange?:any
}

const InputField = (props:InputFieldProps)=>{
    const characterCounter = useRef(0);
    const [currentText, setCurrentText] = useState('');

    const onChangeText=(text:string)=>{
        setCurrentText(text);
        props.onChange(text);
        characterCounter.current=text.length;
    }
    return <View style={[styles.inputWrapper, props.counterStyle]}>
        <TextInput
            value={currentText}
            maxLength={props.maxValueCounter}
            onChangeText={(text)=>onChangeText(text)}
            style={[styles.input, props.textStyle]}
            textAlign={props.textAlign?props.textAlign:'center'}
            placeholder={props.placeholder?props.placeholder:'Jane'}
            autoFocus={true}/>
        <View style={styles.errorAndCounterContainer}>
            {props.showCharacterCounter && <Text style={[styles.letterCount, props.counterStyle]}>
                {characterCounter.current}/{props.maxValueCounter} </Text>}

            {props.errorMsg!=''? <InlineError errorMsg={props.errorMsg}/>:<></>}
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
    input:{
        borderBottomWidth:1,
        paddingTop:moderateScale(10),
        borderColor:AntheraStyle.colour.TextGrey,
        fontSize:moderateScale(16.5),
        width:'100%',
    },
    errorAndCounterContainer:{
        flexDirection:'row',
        justifyContent:'space-between',
        width:'100%'
    },
    letterCount:{
        alignSelf:'flex-end',
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        color:AntheraStyle.colour.TextGreyLight,
        fontSize: moderateScale(10.5)
    },
    inputWrapper:{
        alignSelf:'center',
        flexDirection:'column',
        justifyContent:'center',
        alignItems:'center',
        width:moderateScale(300),
    },
    errorText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize: moderateScale(12),
        color: AntheraStyle.colour.error,
    }
});


export default InputField;
