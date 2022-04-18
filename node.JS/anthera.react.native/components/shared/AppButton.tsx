import React, {Component, useState} from 'react'
import {
    StyleSheet,
    View,
    Text,
    TouchableOpacity, ViewStyle, TextStyle, TouchableHighlight
} from 'react-native'
// @ts-ignore
import {BoxShadow} from 'react-native-shadow'
import {AntheraStyle, moderateScale, screenDeviation, verticalScale} from "../../styles/AntheraStyle";

type AppButtonProps={
    width:{smallScreen:number, phoneScreen:number, largeScreen:number}
    height:{smallScreen:number, phoneScreen:number, largeScreen:number}
    text:string,
    shadowPos_X:number,
    shadowPos_Y:number,
    onPress:()=>void,
    textStyle?:TextStyle,
    btnStyle?:ViewStyle,
    isDebug?:boolean
}

const AppButton = (props:AppButtonProps)=>{

    const shadowOpt = {
        width:screenDeviation(props.width.smallScreen-7.5,props.width.phoneScreen-8.5, props.width.largeScreen-7),
        height:screenDeviation(props.height.smallScreen-7, props.height.phoneScreen-6, props.height.largeScreen-9),
        color:props.isDebug? "#000": '#919191',
        border: 10,
        radius: 10,
        opacity:0.19,
        x:props.shadowPos_X,
        y:props.shadowPos_Y,
    }
    return (
        <View>
            <BoxShadow setting={shadowOpt}>
                <TouchableOpacity
                    onPress={props.onPress}
                    style={[styles.btn, {
                        width: screenDeviation(props.width.smallScreen,props.width.phoneScreen, props.width.largeScreen),
                        height: screenDeviation(props.height.smallScreen, props.height.phoneScreen, props.height.largeScreen)}, props.btnStyle]} >
                    <Text style={[styles.btnText,props.textStyle]}>{props.text}</Text>
                </TouchableOpacity>
            </BoxShadow>
        </View>
    )
}
const styles = StyleSheet.create({

    btn:{
        backgroundColor:'#fff',
        borderWidth:moderateScale(1),
        borderColor: AntheraStyle.colour.main,
        borderRadius: screenDeviation(30, 30,30),
        justifyContent:'center',
        alignSelf:'center',
    },
    btnText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.headerSmall,
        alignSelf:'center',
        color:AntheraStyle.colour.main,
    }})

export default AppButton;
