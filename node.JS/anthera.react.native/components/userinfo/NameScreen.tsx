import {StyleSheet, Text, View} from "react-native";
import UserInfo from "./UserInfo";

const NameScreen = ()=>{
    return <UserInfo
        tilePrefix={'Okay first, what is your '}
        titleHighLighted={'name '}
        titlePostfix={'?'}
        onContinue={'DobScreen'}
        onGoBack={'GenderScreen'} children={<Text>aaaa</Text>}/>
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});

export default NameScreen;
