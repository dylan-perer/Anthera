import {StyleSheet, Text, TouchableOpacity, View} from "react-native";
import LogoWithName from "../../assets/svgs/LogoWithName";
import * as Animatable from 'react-native-animatable';
import {AntheraStyle, moderateScale, scale, screen, screenDeviation, verticalScale} from "../../styles/AntheraStyle";
import {StackParamList, UserInfoScreens} from "../../components/navigators/SignupNavigator";
import {useContext, useEffect, useRef} from "react";
import AppBottomModal from "../../components/shared/AppBottomModal";
import AppSearchInput from "../../components/shared/AppSearchInput";
import AppList from "../../components/shared/AppList";
import AppSearchList from "../../components/shared/AppSearchList";
import AppButton from "../../components/shared/AppButton";
import {signupAsync, identityApi, SignupRequest} from "../../api/AntheraApi";
import {NativeStackScreenProps} from "@react-navigation/native-stack";
import {UserInfoContext} from "../../contexts/UserInfoContext";

const SignupScreen =({route, navigation}:NativeStackScreenProps<StackParamList, 'SignupScreen'>)=>{
    // console.log(context)
    const searchListRef = useRef<AppBottomModal>();
    const userInfoContext = useContext(UserInfoContext)

    const onGenderPress = (screenName: UserInfoScreens, gender:string)=>{
        if(userInfoContext!=null){
            userInfoContext.gender=gender;
            navigation.navigate('NameScreen');
        }
    }

    const DATA = [
        {
            id: 'bd7acbea-c1b1-46c2-aed5-3ad53abb28ba',
            title: 'First Item',
        },
        {
            id: '3ac68afc-c605-48d3-a4f8-fbd91aa97f63',
            title: 'Second Item',
        },
        {
            id: '58694a0f-3da1-471f-bd96-145571e29d72',
            title: 'Third Item',
        },
    ];

    return (
        <View style={styles.container}>
            <Animatable.View animation={"fadeIn"} duration={2000}>
                <LogoWithName {...styles.logo} />
            </Animatable.View>

            <View style={styles.textContainer}>
                <Animatable.Text animation={'fadeIn'} duration={5000} style={[styles.text, {marginRight:moderateScale(100)}]}>Hello there,</Animatable.Text>
                <Animatable.Text animation={'fadeIn'} duration={5000} delay={1400} style={[styles.text, {marginLeft:moderateScale(100)}]}>Lets get you sorted.</Animatable.Text>
            </View>


            <Animatable.View animation={'fadeIn'} duration={2000} delay={3000}>
                <View style={styles.btnContainer}>
                    <AppButton
                        onPress={()=>onGenderPress('NameScreen', 'female')}

                        width={{smallScreen:140,phoneScreen:125,largeScreen:140}}
                        height={{smallScreen:45,phoneScreen:38,largeScreen:35}}

                        shadowPos_X={0}
                        shadowPos_Y={screenDeviation(4,5,5)}

                        btnStyle={[{borderColor:AntheraStyle.colour.accent}]}
                        textStyle={{color:AntheraStyle.colour.accent}}

                        text={'Female'}
                    />

                    <AppButton
                        onPress={()=>onGenderPress('NameScreen','male')}

                        width={{smallScreen:140,phoneScreen:125,largeScreen:140}}
                        height={{smallScreen:45,phoneScreen:38,largeScreen:35}}

                        shadowPos_X={0}
                        shadowPos_Y={screenDeviation(4,5,5)}

                        text={'Male'}
                    />
                </View>
            </Animatable.View>

            <TouchableOpacity style={styles.moreChoicesBtn} onPress={()=>searchListRef.current?.show()}>
                <AppSearchList
                    modalRef={(ref)=>searchListRef.current=ref}
                    data={DATA}
                    onSearchValueChange={(text)=>{}}
                    onCancel={()=>searchListRef.current?.close()}
                    keyExtractor={(item) => item.id}
                    itemTemplate={(item)=><TouchableOpacity><Text>{item.id} {item.title}</Text></TouchableOpacity>}
                />
                <Animatable.Text animation={"fadeIn"} duration={2000} delay={3500} style={styles.moreChoicesText}>More choices</Animatable.Text>
            </TouchableOpacity>


    </View>)
}



const styles = StyleSheet.create({
    container:{
        flex:1,
        marginVertical:verticalScale(80)
    },
    logo:{
        alignSelf:'center',
        width:moderateScale(165),
        height:verticalScale(165),
    },
    textContainer:{
        width:screen.width,
        flexDirection:'column',
        alignItems:'center',
        justifyContent:'center'
    },
    text:{
        fontFamily:AntheraStyle.font.nunito_regular,
        fontSize:AntheraStyle.font.size.header
    },
    btnContainer: {
        flexDirection:'row',
        justifyContent:'space-between',
        alignContent:'center',
        marginTop:verticalScale(60),
        alignSelf:'center',
        width:screenDeviation(290,260,300),
    },
    moreChoicesBtn:{
        marginTop:verticalScale(20),
        alignItems:'center'
    },
    moreChoicesText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.textMedium,
        color:AntheraStyle.colour.mid
    },
});

export default SignupScreen;
