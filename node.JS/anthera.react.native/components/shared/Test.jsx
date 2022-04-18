import React, {Component} from 'react'
import {
    StyleSheet,
    View,
    Text,
    ScrollView,
    Image,
    TouchableHighlight, TouchableOpacity
} from 'react-native'

import {BoxShadow} from 'react-native-shadow'
import {AntheraStyle, moderateScale, screenDeviation, verticalScale} from "../../styles/AntheraStyle";

const Ass = ()=>{
    const shadowOpt = {
        width:screenDeviation(170,125,140),
        height:screenDeviation(45, 30, 35),
        color:"#919191",
        border: 10,
        radius: 10,
        opacity:0.15,
        x:screenDeviation(4,6.5,5),
        y:screenDeviation(4,3,5),
    }
    return (
        <View style={{marginTop:200}}>
        <BoxShadow setting={shadowOpt}>
            <TouchableOpacity style={styles.btn} >
                <Text style={styles.btnText}>Female</Text>
            </TouchableOpacity>
        </BoxShadow>
        </View>
    )
}
const styles = StyleSheet.create({

    btn:{
        backgroundColor:'#fff',
        borderWidth:1.5,
        borderColor:'#FFC1F5',
        borderRadius: screenDeviation(30, 30,30),
        width:screenDeviation(170,130,140),
        height:screenDeviation(45, 35, 35),
        marginHorizontal:moderateScale(5),
        justifyContent:'center'
    },
    btnText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.headerSmall,
        alignSelf:'center',
        color:'#FFC1F5'
    }})
export default Ass;
