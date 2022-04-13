import { StyleSheet, Text, View } from 'react-native'
import React from 'react'
import UserInfo from './UserInfo';
import NameSvg from '../../assets/svgs/userinfo.name';
import { StackNavigationProp } from '@react-navigation/stack';


const NameScreen = ({navigation}: {navigation: any}) => {

  return (
        <UserInfo 
          navigation={navigation} 
          titleStart='My ' 
          titleHighLighted='name ' 
          titleEnd=' is...' 
          SVG={<NameSvg/>} 
          svgStyle={styles.svg}
          goBack={'GenderScreen'}
          goNext={'DobScreen'}
          
          >
          <Text>aa</Text>
        </UserInfo>
  )
}

export default NameScreen

const styles = StyleSheet.create({
    svg:{
        width:400,
        height:400
    }
})