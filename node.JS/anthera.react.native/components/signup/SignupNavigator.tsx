import {createStackNavigator, TransitionPresets} from "@react-navigation/stack";
import SignupScreen from './SignupScreen';
import {AntheraStyle} from "../../styles/AntheraStyle";
import NameScreen from "../userinfo/NameScreen";

export type UserInfoScreens = 'GenderScreen' | 'NameScreen' | 'DobScreen' | 'HereToScreen' | 'None'

export type StackParamList ={
    SignupScreen:undefined,
    NameScreen:undefined
}
const SignupNavigator =()=>{
    const Stack = createStackNavigator<StackParamList>();

    return <Stack.Navigator initialRouteName='SignupScreen' screenOptions={{
        headerShown: false,
        cardStyle: { padding:0, margin:0, backgroundColor: AntheraStyle.colour.BackgroundGrey },
        // gestureEnabled: true,
        // gestureDirection: "horizontal",s
        ...TransitionPresets.SlideFromRightIOS,
    }}>
        <Stack.Screen name='SignupScreen' component={SignupScreen}/>
        <Stack.Screen name='NameScreen' component={NameScreen}/>
    </Stack.Navigator>
}

export default SignupNavigator;
