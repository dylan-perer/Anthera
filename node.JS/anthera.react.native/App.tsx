import { StatusBar } from 'expo-status-bar';
import {SafeAreaView, StyleSheet, Text, View} from 'react-native';
import {NavigationContainer} from "@react-navigation/native";
import SignupNavigator from "./components/signup/SignupNavigator";
import {useFonts} from "expo-font";
import AppLoading from "expo-app-loading";

export default function App() {
  let [fontsLoaded, error]=useFonts({
    'Questrial-Regular': require('./assets/fonts/Questrial-Regular.ttf'),
    'Nunito-SemiBold': require('./assets/fonts/Nunito-SemiBold.ttf'),
    'Nunito-Regular': require('./assets/fonts/Nunito-Regular.ttf'),
  });

  if(!fontsLoaded){
    return <AppLoading/>;
  }
  return (
      <NavigationContainer>
          <StatusBar style='auto'/>
          <SignupNavigator/>
      </NavigationContainer>
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
