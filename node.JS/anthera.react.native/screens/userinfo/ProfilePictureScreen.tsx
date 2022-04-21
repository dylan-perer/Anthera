import UserInfo from "./UserInfo";
import FemaleAvatar from "../../assets/svgs/FemaleAvatar";
import {StyleSheet, Text, TouchableOpacity, View} from "react-native";
import {
    AntheraStyle,
    isPhoneScreen,
    isSmallPhoneScreen,
    moderateScale,
    screenDeviation
} from "../../styles/AntheraStyle";
import {NativeStackScreenProps} from "@react-navigation/native-stack";
import {StackParamList} from "../../components/navigators/SignupNavigator";
import {AntheraResponse, signupAsync, SignupRequest, uploadImgAsync} from "../../api/AntheraApi";
import {useContext, useRef} from "react";
import {UserInfoContext} from "../../contexts/UserInfoContext";
import AppSemiBottomModal from "../../components/shared/AppSemiBottomModal";
import RBSheet from "react-native-raw-bottom-sheet";
import AppSvgIcon from "../../components/shared/AppSvgIcon";
import CameraIcon from "../../assets/svgs/icons/CameraIcon";
import ImageBrowseIcon from "../../assets/svgs/icons/ImageBrowseIcon";
import * as ImagePicker from "expo-image-picker";
import {AntherContext} from "../../contexts/AntheraContext";

const ProfilePictureScreen=({route, navigation}:NativeStackScreenProps<StackParamList, 'ProfilePictureScreen'>)=>{
    const userInfoContext = useContext(UserInfoContext);
    const antheraContext = useContext(AntherContext);
    const semiBottomModalRef = useRef<RBSheet>();
    const pictureUri = useRef<string>();

    const onContinue = async () => {
        //sign up user
        const signup:SignupRequest={
            ...userInfoContext
        }

        if(antheraContext!=null){
            const res:AntheraResponse = await signupAsync(signup, antheraContext);
            console.log(res);
            console.log(antheraContext);
            const token = antheraContext.token;

            //upload picture
            if(pictureUri.current!=undefined && token!=null){
                await uploadImgAsync(pictureUri.current,token);
            }
        }


    }

    const openCameraTakePicture = async ()=>{
        let result = await ImagePicker.launchCameraAsync({
            allowsEditing: true,
            aspect: [4, 5],
        });

        if (result.cancelled) {
            return;
        }

        pictureUri.current= result.uri;
    }

    return <UserInfo
        tilePrefix={'Nice one! Time for an '}
        titleHighLighted={'profile picture.'}
        titlePostfix={''}
        hint={'Choose your best! You can add more or change photos later.'}
        onContinue={onContinue}
        onGoBack={()=>navigation.navigate('EmailAndPasswordScreen')}
        btnText={'Complete'}
        titleContainerStyle={{alignItems:'flex-start'}}
        btnStyle={{marginTop: screenDeviation(60,65,80)}}
    >
        <>
        <TouchableOpacity style={styles.profilePictureContainer} onPress={()=>semiBottomModalRef.current?.open()}>
            <FemaleAvatar {...styles.svg}/>
        </TouchableOpacity>

        <AppSemiBottomModal
            setRef={(ref: RBSheet)=>{semiBottomModalRef.current=ref}}
            height={screenDeviation(170,180,180)}>
            <View style={styles.semiBottomModalBtnContainer}>
                <AppSvgIcon
                    label={'Camera'}
                    Svg={<CameraIcon {...styles.semiBottomModalCamera}/>}
                    onPress={openCameraTakePicture}
                    styleContainer={{marginRight:screenDeviation(40,40,40)}}/>
                <AppSvgIcon
                    label={'Browse'}
                    Svg={<ImageBrowseIcon {...styles.semiBottomModalImageBrowse}/>}
                    onPress={()=>{}}
                    styleContainer={{marginLeft:screenDeviation(40,40,40)}}/>
            </View>
        </AppSemiBottomModal>
        </>
    </UserInfo>
}


const styles = StyleSheet.create({
    profilePictureContainer:{
        alignSelf:'center',
        flexDirection:'row',
        justifyContent:'center',
        // backgroundColor:'red',
        width:isSmallPhoneScreen? moderateScale(100): isPhoneScreen? moderateScale(150):moderateScale(120),
        borderRadius:moderateScale(40),
        marginTop: screenDeviation(45,15,15)
    },
    svg:{
        width: isSmallPhoneScreen? moderateScale(120): isPhoneScreen? moderateScale(150):moderateScale(120),
        height:isSmallPhoneScreen? moderateScale(120): isPhoneScreen? moderateScale(150):moderateScale(120),
    },
    semiBottomModalBtnContainer:{
        flexDirection:'row',
        justifyContent:'center',
        alignSelf:'center',
        marginTop:screenDeviation(20,30,30)
    },
    semiBottomModalImageBrowse:{
        color:AntheraStyle.colour.mid,
        width:screenDeviation(40,40,40),
        height:screenDeviation(40,40,40),
    },
    semiBottomModalCamera:{
        color:AntheraStyle.colour.mid,
        width:screenDeviation(40,40,40),
        height:screenDeviation(40,40,40),
    },
})
export default ProfilePictureScreen;
