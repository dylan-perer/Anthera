import {StyleSheet, Text, View} from "react-native";
import {UserInfoScreens} from "../signup/SignupNavigator";

type UserInfoProps={
    tilePrefix:string,
    titleHighLighted: string,
    titlePostfix:string,
    hint?:string,
    children: JSX.Element,
    onContinue: UserInfoScreens,
    onGoBack: UserInfoScreens
}

const UserInfo = (props:UserInfoProps)=>{
    return <View>
        <View>
            <Text>{props.tilePrefix}</Text>
            <Text>{props.titleHighLighted}</Text>
            <Text>{props.titlePostfix}</Text>
        </View>

    </View>
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});

export default UserInfo;
