import { StyleSheet, Text, View } from 'react-native'
import React from 'react'
import UserInfo from './UserInfo';
import NameSvg from '../../assets/svgs/userinfo.name';
import { TextInput } from 'react-native-gesture-handler';

const NameScreen = () => {

  return (

    <View>
        <UserInfo titleStart={"My"} titleHighted={" name"} titleEnd={" is..."} Svg={NameSvg} svgStyle={styles.svg}>
          <TextInput placeholder='asssss'/>
        </UserInfo>
    </View>
  )
}

export default NameScreen

const styles = StyleSheet.create({
    svg:{
        width:400,
        height:400
    },
    
})