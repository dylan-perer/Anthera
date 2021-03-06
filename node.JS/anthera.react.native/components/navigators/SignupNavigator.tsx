import {createStackNavigator, TransitionPresets} from "@react-navigation/stack";
import SignupScreen from '../../screens/entry/SignupScreen';
import {AntheraStyle, moderateScale} from "../../styles/AntheraStyle";
import NameScreen from "../../screens/userinfo/NameScreen";
import DobScreen from "../../screens/userinfo/DobScreen";
import HeretoScreen from "../../screens/userinfo/HeretoScreen";
import SexPreferenceScreen from "../../screens/userinfo/SexPreferenceScreen";
import EmailAndPasswordScreen from "../../screens/userinfo/EmailAndPasswordScreen";
import ProfilePictureScreen from "../../screens/userinfo/ProfilePictureScreen";
import {UserInfoContextProvider} from "../../contexts/UserInfoContext";
import AppCamera from "../shared/AppCamera";

export type UserInfoScreens = 'SignupScreen' | 'GenderScreen' | 'NameScreen' | 'DobScreen' | 'HereToScreen' | 'None'

export type StackParamList ={
    SignupScreen:undefined,
    NameScreen:undefined,
    DobScreen:undefined,
    HeretoScreen:undefined,
    SexPreferenceScreen:undefined,
    EmailAndPasswordScreen:undefined,
    ProfilePictureScreen:undefined,
}
const SignupNavigator =()=>{
    const Stack = createStackNavigator<StackParamList>();

    return <UserInfoContextProvider>
        <Stack.Navigator initialRouteName='ProfilePictureScreen' screenOptions={{
            headerShown: false,
            cardStyle: { padding:0, margin:0, backgroundColor: AntheraStyle.colour.BackgroundGrey },
            // gestureEnabled: true,
            // gestureDirection: "horizontal",s
            ...TransitionPresets.SlideFromRightIOS,
        }}>
            <Stack.Screen name='SignupScreen' component={SignupScreen}/>
            <Stack.Screen name='NameScreen' component={NameScreen}/>
            <Stack.Screen name='DobScreen' component={DobScreen}/>
            <Stack.Screen name='HeretoScreen' component={HeretoScreen}/>
            <Stack.Screen name='SexPreferenceScreen' component={SexPreferenceScreen}/>
            <Stack.Screen name='EmailAndPasswordScreen' component={EmailAndPasswordScreen}/>
            <Stack.Screen name='ProfilePictureScreen' component={ProfilePictureScreen}/>
        </Stack.Navigator>
    </UserInfoContextProvider>
}



export default SignupNavigator;
