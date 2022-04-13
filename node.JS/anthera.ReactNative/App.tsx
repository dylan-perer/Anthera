import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import FirstBootScreen from './Components/Signup/FirstBootScreen';
import {useFonts} from 'expo-font';
import AppLoading from 'expo-app-loading';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator, TransitionPresets } from '@react-navigation/stack';
import GenderScreen from './Components/UserInfo/GenderScreen';
import {AntheraStyle} from './Constants/Styles/AntheraStyles';
import SignupNavigator from './Components/Signup/SignupNavigator';

export default function App() {
  console.log("hellpo");
  let [fontsLoded, error]=useFonts({
    'Questrial-Regular': require('./assets/fonts/Questrial-Regular.ttf')
  });

  if(!fontsLoded){
    return <AppLoading/>
  }
  return (
    <SignupNavigator/>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
