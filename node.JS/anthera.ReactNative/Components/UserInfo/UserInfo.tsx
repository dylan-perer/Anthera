import { KeyboardAvoidingView, StyleSheet, Text, View, ViewStyle, TouchableOpacity } from 'react-native'
import React, {useRef, useState} from 'react';
import { moderateScale } from '../../misc/Anthera.Dimension';
import * as Animatable from 'react-native-animatable';
import { DetailScreenStyles } from '../../Constants/Styles/DetailScreenStyles';
import { ScrollView } from 'react-native-gesture-handler';
import { AntheraStyle,screen } from '../../Constants/Styles/AntheraStyles';
import Nextbtn from '../../assets/svgs/userinfo.nextbtn'
import Backbtn from '../../assets/svgs/userinfo.backbtn'

type userInfoScreens = 'GenderScreen' | 'NameScreen' | 'DobScreen' | 'HereToScreen' | 'None'

type UserDetailProp = {
  titleStart?: string,
  titleHighLighted: string,
  titleEnd: string,
  SVG: JSX.Element,
  children: JSX.Element,
  svgStyle: ViewStyle,
  navigation: any,
  goBack: userInfoScreens,
  goNext: userInfoScreens,
}

const UserInfo = (props: UserDetailProp) => {
  let isNoBackBtn = {opacity:1,isDisabled:false}
  let isNoNextBtn = {opacity:1,isDisabled:false}

  if(props.goBack=='None'){
    isNoBackBtn = {opacity:0, isDisabled:true}
  }

  if(props.goNext=='None'){
    isNoNextBtn = {opacity:0, isDisabled:true}
  }

  const navigateUserinfoScreensBackwards=()=>{
      props.navigation.navigate(props.goBack)
  }

  const navigateUserinfoScreensForwards=()=>{
    props.navigation.navigate(props.goNext)
}
  return (
    <KeyboardAvoidingView>
      <ScrollView style={styles.container}>

        {/* top text */}
        <Animatable.Text {...DetailScreenStyles.anim.topTextAnim} style={DetailScreenStyles.topText}>{props.titleStart}
          <Text style={DetailScreenStyles.topTextPrimary}>{props.titleHighLighted}</Text>
          <Text style={DetailScreenStyles.topText}>{props.titleEnd}</Text>
        </Animatable.Text>

        {/* svg */}
        <Animatable.View animation='fadeInUp' duration={2000} iterationCount='infinite'>
          {props.SVG}
        </Animatable.View>

        {/* content */}
        {props.children}

      <View style={styles.btnWrapper}>
      <TouchableOpacity style={[styles.backBtn, {opacity:isNoBackBtn.opacity}]} disabled={isNoBackBtn.isDisabled} onPress={()=>{props.navigation.navigate(props.goBack)}}><Backbtn/></TouchableOpacity>
      <TouchableOpacity style={[styles.nextBtn, {opacity:isNoNextBtn.opacity}]} disabled={isNoNextBtn.isDisabled} onPress={()=>{props.navigation.navigate(props.goNext)}}><Nextbtn/></TouchableOpacity>
    </View>

      </ScrollView>
    </KeyboardAvoidingView>
  )
}

const animation = {
  0: {
      opacity: 0
  },
  1: {
      opacity: 1
  },
  duration: 2000
}

export default UserInfo

const styles = StyleSheet.create({
  container: {
    backgroundColor: AntheraStyle.colour.BackgroundGrey
  },
  btnWrapper:{
    flexDirection:'row',
    width:screen.width,
    justifyContent:'space-between',
    alignItems:'center',
  },
  nextBtn:{
    marginRight: moderateScale(30),
  },
  backBtn:{
    marginLeft: moderateScale(30),
  }
})