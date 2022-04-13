import {useFonts} from 'expo-font';
import AppLoading from 'expo-app-loading';
import SignupNavigator from './screens/signup/SignupNavigator';

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

