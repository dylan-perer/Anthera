import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import FirstBootScreen from './Components/FirstBootScreen';
import {useFonts} from 'expo-font';
import AppLoading from 'expo-app-loading';

export default function App() {
  console.log("hellpo");
  let [fontsLoded, error]=useFonts({
    'Questrial-Regular': require('./assets/fonts/Questrial-Regular.ttf')
  });

  if(!fontsLoded){
    return <AppLoading/>
  }

  return (
    <View style={styles.container}>
      <FirstBootScreen/>
    </View>
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
