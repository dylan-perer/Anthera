import { StyleSheet, Text, View } from 'react-native'
import React, { useRef, useState, useEffect } from 'react'
import * as Animatable from 'react-native-animatable';
import { AntheraStyle, verticalScale, moderateScale, scale, isPhoneScreen } from '../../Styles/AntheraStyles';
import {DetailScreenStyles} from '../../Styles/DetailScreenStyles';
import Svg from '../../assets/svgs/gender.select';
import { TouchableOpacity } from 'react-native-gesture-handler';
import UserInfo from './UserInfo';

const GenderScreen = ({navigation}) => {
    const [isWomen, setIsWoman] = useState(false);
    const btnSelectedStyle = useRef({ man: { btn: {}, btnText: {} }, woman: { btn: {}, btnText: {} } });

    useEffect(() => {
        onBtnPress();
    }, []);

    //handle on select gender
    const onBtnPress = () => {
        if (isWomen) {
            btnSelectedStyle.current.man.btn = styles.primaryButtonSelected;
            btnSelectedStyle.current.man.btnText = styles.buttonTextSelected;
            btnSelectedStyle.current.woman.btn = {};
            btnSelectedStyle.current.woman.btnText = {};
        } else {
            btnSelectedStyle.current.woman.btn = styles.primaryButtonSelected;
            btnSelectedStyle.current.woman.btnText = styles.buttonTextSelected;
            btnSelectedStyle.current.man.btn = {};
            btnSelectedStyle.current.man.btnText = {};
        }
        setIsWoman(!isWomen);
    }

    return (
        <UserInfo titleHighted={'I am'} titleEnd={' a...'} Svg={Svg} svgStyle={styles.svg} navigation={navigation}>
            <View>
             <View style={styles.buttonWrapper}>
                <TouchableOpacity onPress={onBtnPress} style={[styles.primaryButton, btnSelectedStyle.current.woman.btn, styles.womanButton]} >
                    <Text style={[styles.buttonText, btnSelectedStyle.current.woman.btnText]}>Woman</Text>
                </TouchableOpacity>
                <TouchableOpacity onPress={onBtnPress} style={[styles.primaryButton, btnSelectedStyle.current.man.btn, styles.manButton]} >
                    <Text style={[styles.buttonText, btnSelectedStyle.current.man.btnText]}>Man</Text>
                </TouchableOpacity>
            </View>
            <TouchableOpacity style={styles.secondaryButton} ><Text style={[styles.buttonText, styles.secondaryButtonText]}>More Choices</Text></TouchableOpacity> 
            </View>
        </UserInfo>
    )
}

export default GenderScreen

const styles = StyleSheet.create({
    svg: {
        width: moderateScale(400),
        height: verticalScale(400)
    },
    topText: {
        fontFamily: AntheraStyle.font.Questrial,
        fontSize: AntheraStyle.font.size.header,
        color: AntheraStyle.colour.TextGrey
    },
    topTextPrimary: {
        color: AntheraStyle.colour.MainBlue
    },
    buttonWrapper: {
        flexDirection: 'row',
        justifyContent: 'center'
    },
    buttonText: {
        color: AntheraStyle.colour.TextGrey,
        fontFamily: AntheraStyle.font.Questrial,
        fontSize: AntheraStyle.font.size.header
    },
    primaryButton: {
        borderColor: AntheraStyle.colour.borderBlue,
        width: moderateScale(100),
        height: isPhoneScreen ? scale(42) : scale(30),
        alignItems: 'center',
        justifyContent: 'center',
        borderWidth: moderateScale(1),
    },
    primaryButtonSelected: {
        backgroundColor: AntheraStyle.colour.MainBlue,
    },
    buttonTextSelected: {
        color: 'white'
    },
    womanButton: {
        borderTopLeftRadius: moderateScale(6),
        borderBottomLeftRadius: moderateScale(6),
    },
    manButton: {
        borderTopRightRadius: moderateScale(6),
        borderBottomRightRadius: moderateScale(6),
    },
    secondaryButton: {
        alignSelf: 'center',
        borderWidth: moderateScale(1),
        borderColor: AntheraStyle.colour.borderBlue,
        marginVertical: verticalScale(10),
        height: isPhoneScreen ? scale(42) : scale(30),
        width: moderateScale(200),
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: moderateScale(6),
    },
    secondaryButtonText: {
        color: AntheraStyle.colour.TextGrey,
    }

})