import UserInfo from "./UserInfo";
import {StyleSheet, Text, View} from "react-native";
import AppRadioBtn from "../../components/shared/AppRadioBtn";
import Coffee from "../../assets/svgs/Coffee";
import Chat from "../../assets/svgs/Chat";
import Heart from "../../assets/svgs/heart";
import {AntheraStyle, isPhoneScreen, moderateScale, screenDeviation} from "../../styles/AntheraStyle";
import {useRef, useState} from "react";


const SexPreferenceScreen=({navigation}:{navigation:any})=>{
    const value = useRef<string>();

    const [radioBtn1, setRadioBtn1] = useState(false);
    const [radioBtn2, setRadioBtn2] = useState(false);
    const [radioBtn3, setRadioBtn3] = useState(false);

    const onContinue=()=>{
        if(value.current!=null){
            console.log(value.current)
            navigation.navigate('EmailAndPasswordScreen')
        }
    }

    const onPress=(val:string,state:any)=>{
        value.current=val
        setRadioBtn1(false);
        setRadioBtn2(false);
        setRadioBtn3(false);

        state(true)
    }
        return <UserInfo
            tilePrefix={'Nearly there! Who do you want to be '}
            titleHighLighted={'shown '}
            titlePostfix={'to?'}
            onContinue={()=>{onContinue()}}
            onGoBack={()=>{navigation.navigate('HeretoScreen')}}>
            <View style={[{alignSelf:'center'},{marginTop: screenDeviation(20,0,0)}]}>
                <AppRadioBtn style={styles.radioBtnContainer}
                             setSelected={setRadioBtn1} value={'men'}
                             onPress={(val)=>{onPress(val,setRadioBtn1)}}
                             isSelected={radioBtn1}>
                    <View style={styles.itemContainer}>
                        <View style={styles.textWrapper}>
                            <Text style={styles.subHeader}>To people looking for women.</Text>
                        </View>
                    </View>
                </AppRadioBtn>
                <AppRadioBtn style={styles.radioBtnContainer}
                             setSelected={setRadioBtn2}
                             value={'women'}
                             onPress={(val)=>{onPress(val,setRadioBtn2)}} isSelected={radioBtn2}>
                    <View style={styles.itemContainer}>
                        <View style={styles.textWrapper}>
                            <Text style={styles.subHeader}>To people looking for men.</Text>
                        </View>
                    </View>
                </AppRadioBtn>
                <AppRadioBtn style={styles.radioBtnContainer}
                             setSelected={setRadioBtn3}
                             value={'both'}
                             onPress={(val)=>{onPress(val,setRadioBtn3)}}
                             isSelected={radioBtn3}>
                    <View style={styles.itemContainer}>
                        <View style={styles.textWrapper}>
                            <Text style={styles.subHeader}>To people looking for both women and men.</Text>
                        </View>
                    </View>
                </AppRadioBtn>
            </View>
        </UserInfo>
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
    radioBtnContainer:{
        paddingHorizontal:moderateScale(10),
        paddingVertical:moderateScale(12),
        marginBottom:moderateScale(10)
    },
    itemContainer:{
        flexDirection:'row',
        width: isPhoneScreen? moderateScale(280):moderateScale(200),
        justifyContent:'space-between',
        alignItems:'center'
    },
    textWrapper:{

    },
    subHeader:{
        fontFamily:AntheraStyle.font.nunito_regular,
        fontSize:AntheraStyle.font.size.subHeader
    },
    details:{
        fontFamily:AntheraStyle.font.nunito_regular,
        color:AntheraStyle.colour.TextGreyLight,
        fontSize:AntheraStyle.font.size.textVerySmall
    },
    svg:{
        width: isPhoneScreen?moderateScale(25):moderateScale(20),
        height:isPhoneScreen?moderateScale(25):moderateScale(20),
    }
});

export default SexPreferenceScreen;
