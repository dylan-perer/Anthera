import {StyleSheet, Text, TouchableOpacity, View} from "react-native";
import LogoWithName from "../../assets/svgs/LogoWithName";
import * as Animatable from 'react-native-animatable';
import {AntheraStyle, moderateScale, scale, screen, screenDeviation, verticalScale} from "../../styles/AntheraStyle";
import {UserInfoScreens} from "./SignupNavigator";
import {useRef} from "react";
import BottomModal from "../shared/BottomModal";
import SearchInput from "../shared/SearchInput";
import List from "../shared/List";
import SearchList from "../shared/SearchList";

const SignupScreen =({navigation}: {navigation: any})=>{
    const searchListRef = useRef<BottomModal>();
    const genderValueRef = useRef<string>();

    const onGenderPress = (screenName: UserInfoScreens)=>{
        navigation.navigate(screenName)
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

    return <View style={styles.container}>

        <Animatable.View animation={"fadeIn"} duration={2000}>
            <LogoWithName {...styles.logo} />
        </Animatable.View>

        <View style={styles.textContainer}>
            <Animatable.Text animation={'fadeIn'} duration={5000} style={[styles.text, {marginRight:moderateScale(100)}]}>Hello there,</Animatable.Text>
            <Animatable.Text animation={'fadeIn'} duration={5000} delay={1400} style={[styles.text, {marginLeft:moderateScale(100)}]}>Lets get you sorted.</Animatable.Text>
        </View>


        <Animatable.View animation={'fadeIn'} duration={2000} delay={3000}>
            <View style={styles.btnContainer}>
                <TouchableOpacity style={styles.btn} onPress={()=>onGenderPress('NameScreen')}>
                    <Text style={styles.btnText}>Female</Text>
                </TouchableOpacity>
                <TouchableOpacity style={styles.btn} onPress={()=>onGenderPress('NameScreen')}>
                    <Text style={styles.btnText}>Male</Text>
                </TouchableOpacity>
            </View>
        </Animatable.View>

        <TouchableOpacity style={styles.moreChoicesBtn} onPress={()=>searchListRef.current?.show()}>
            <SearchList
                modalRef={(ref)=>searchListRef.current=ref}
                data={DATA}
                onSearchValueChange={(text)=>{}}
                onCancel={()=>searchListRef.current?.close()}
                keyExtractor={(item) => item.id}
                itemTemplate={(item)=><TouchableOpacity><Text>{item.id} {item.title}</Text></TouchableOpacity>}
            />
            <Animatable.Text animation={"fadeIn"} duration={2000} delay={3500} style={styles.moreChoicesText}>More choices</Animatable.Text>
        </TouchableOpacity>


    </View>
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
        width:screen.width,
        flexDirection:'row',
        alignItems:'center',
        justifyContent:'center',
        marginTop:verticalScale(60),
    },
    btn:{
        borderWidth:1.5,
        borderColor:AntheraStyle.colour.main,
        borderRadius: moderateScale(30),
        width:moderateScale(130),
        marginHorizontal:moderateScale(5)
    },
    btnText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.headerSmall,
        paddingVertical:moderateScale(7),
        alignSelf:'center',
        color:AntheraStyle.colour.main
    },
    bottomModal:{
        maxWidth:screenDeviation(350,320,280),
    }
    ,
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
