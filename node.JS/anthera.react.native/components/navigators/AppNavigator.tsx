import {createStackNavigator, TransitionPresets} from "@react-navigation/stack";
import {AntheraStyle, moderateScale} from "../../styles/AntheraStyle";
import {UserInfoContextProvider} from "../../contexts/UserInfoContext";

import SettingsScreen from "../../screens/account/SettingsScreen";
import EditUserInfoScreen from "../../screens/account/EditUserInfoScreen";
import AccountScreen from "../../screens/account/AccountScreen";

export type AppNavigatorScreens = 'SettingsScreen' | 'AccountScreen' | 'EditUserInfoScreen' | 'none';

export type StackParamList ={
    SettingsScreen:undefined,
    EditUserInfoScreen:undefined,
    AccountScreen:undefined
}
const AppNavigator =()=>{
    const Stack = createStackNavigator<StackParamList>();

    return <UserInfoContextProvider>
        <Stack.Navigator initialRouteName='AccountScreen' screenOptions={{
            headerShown: false,
            cardStyle: { padding:0, margin:0, backgroundColor: AntheraStyle.colour.BackgroundGrey },
            // gestureEnabled: true,
            // gestureDirection: "horizontal",s
            ...TransitionPresets.SlideFromRightIOS,
        }}>
            <Stack.Screen name='AccountScreen' component={AccountScreen}/>
            <Stack.Screen name='SettingsScreen' component={SettingsScreen}/>
            <Stack.Screen name='EditUserInfoScreen' component={EditUserInfoScreen}/>
        </Stack.Navigator>
    </UserInfoContextProvider>
}



export default AppNavigator;
