import { StatusBar } from 'expo-status-bar';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator, TransitionPresets } from '@react-navigation/stack';
import FirstBootScreen from './FirstBootScreen';
import GenderScreen from '../userinfo/GenderScreen';
import { AntheraStyle } from '../../Styles/AntheraStyles';
import NameScreen from '../userinfo/NameScreen';

export default function App() {
  const Stack = createStackNavigator();
  return (
    <NavigationContainer>
    <Stack.Navigator 
    screenOptions={{
      headerShown: false,
      cardStyle: { padding:0, margin:0, backgroundColor: AntheraStyle.colour.BackgroundGrey },
      // gestureEnabled: true,
      // gestureDirection: "horizontal",
      ...TransitionPresets.SlideFromRightIOS,
    }}>
    <Stack.Screen name="GenderScreen" component={GenderScreen} />
    <Stack.Screen name="NameScreen" component={NameScreen} />
    <Stack.Screen name="FirstBootScreen" component={FirstBootScreen} />
  </Stack.Navigator>
  </NavigationContainer>
  );
}

