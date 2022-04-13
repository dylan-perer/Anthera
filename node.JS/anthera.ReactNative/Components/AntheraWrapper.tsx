import { StyleSheet, Text, View } from 'react-native'
import React from 'react'
import {AntheraStyle}  from '../Constants/Styles/AntheraStyles';
import Decoration  from '../assets/svgs/profile.creation.startup.decoration';

const AntheraWrapper = () => {
  return (
    <View>
      <Text style={{fontFamily:AntheraStyle.font.Questrial}}>AntheraWrapper</Text>
      <Decoration height={600} />
    </View>
  )
}

export default AntheraWrapper

const styles = StyleSheet.create({
    
})