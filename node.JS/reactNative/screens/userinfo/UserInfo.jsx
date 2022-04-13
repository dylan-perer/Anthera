import { StyleSheet, Text, View, KeyboardAvoidingView } from 'react-native'
import React,{useRef} from 'react'
import * as Animatable from 'react-native-animatable';
import {DetailScreenStyles} from '../../Styles/DetailScreenStyles';
import Nextbtn from '../../assets/svgs/userinfo.nextbtn'
import Backbtn from '../../assets/svgs/userinfo.backbtn'
import { ScrollView, TouchableOpacity } from 'react-native-gesture-handler';
import { moderateScale, screen } from '../../misc/Anthera.Dimension';

const UserInfo = ({titleStart, titleHighted, titleEnd, Svg, svgStyle, children, navigation}) => {
  const userinfoScreen = ['GenderScreen','NameScreen'];
  const userinfoScreenIdx = useRef(0);

  const navigateUserinfoScreens=(num)=>{
    userinfoScreenIdx.current+=num;
    let screenName = userinfoScreen[userinfoScreenIdx];
    navigation.navigate(screenName);
  }
  return (
    <KeyboardAvoidingView>
    <ScrollView>
    <Animatable.Text {...DetailScreenStyles.anim.topTextAnim} style={DetailScreenStyles.topText}>{titleStart}
      <Text style={DetailScreenStyles.topTextPrimary}>{titleHighted}</Text>
      <Text style={DetailScreenStyles.topText}>{titleEnd}</Text>
    </Animatable.Text>
    
    <Animatable.View {...DetailScreenStyles.anim.svgAnim}>
      <Svg {...svgStyle}/>
    </Animatable.View>

    <View>{children}</View>

    <View style={styles.btnWrapper}>
      <TouchableOpacity style={styles.backBtn} onPress={()=>{navigateUserinfoScreens(-1)}}><Backbtn/></TouchableOpacity>
      <TouchableOpacity style={styles.nextBtn} onPress={()=>{navigateUserinfoScreens(1)}}><Nextbtn/></TouchableOpacity>
    </View>
    </ScrollView>
    </KeyboardAvoidingView>
  )
}



export default UserInfo

const styles = StyleSheet.create({
  svg:{
    height:300,
    width:300
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