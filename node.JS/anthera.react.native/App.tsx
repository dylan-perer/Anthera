import { StatusBar } from 'expo-status-bar';
import {SafeAreaView, StyleSheet, Text, View} from 'react-native';
import {NavigationContainer} from "@react-navigation/native";
import SignupNavigator from "./components/navigators/SignupNavigator";
import {useFonts} from "expo-font";
import AppLoading from "expo-app-loading";
import {AntherContext, AntherContextProvider} from "./contexts/AntheraContext";
import AppNavigator from "./components/navigators/AppNavigator";
import {useContext, useState} from "react";

export default function App() {
  let [fontsLoaded, error]=useFonts({
    'Questrial-Regular': require('./assets/fonts/Questrial-Regular.ttf'),
    'Nunito-SemiBold': require('./assets/fonts/Nunito-SemiBold.ttf'),
    'Nunito-Regular': require('./assets/fonts/Nunito-Regular.ttf'),
    'Nunito-Bold': require('./assets/fonts/Nunito-Bold.ttf'),
  });

    const antheraContext = useContext(AntherContext);
    const [isUserLogged, setIsUserLogged] = useState<boolean>(antheraContext?.token?true:false);

    if(!fontsLoaded){
    return <AppLoading/>;
  }

    const handleNavigators = ()=>{
        // if(isUserLogged){
        //     return  <AppNavigator/>
        // }else{
        //     return  <SignupNavigator/>
        // }
        return  <AppNavigator/>
    }

    return (
      <AntherContextProvider setIsUserLogged={setIsUserLogged}>
        <NavigationContainer>
            <StatusBar style='auto'/>
            {handleNavigators()}
        </NavigationContainer>
      </AntherContextProvider>
  );
}


const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'red',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
