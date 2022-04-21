import UserInfo from "./UserInfo";
import FemaleAvatar from "../../assets/svgs/FemaleAvatar";
import {Image, StyleSheet, Text, TouchableOpacity, View} from "react-native";
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
import {useContext, useRef, useState} from "react";
import {UserInfoContext} from "../../contexts/UserInfoContext";
import AppSemiBottomModal from "../../components/shared/AppSemiBottomModal";
import RBSheet from "react-native-raw-bottom-sheet";
import AppSvgIcon from "../../components/shared/AppSvgIcon";
import CameraIcon from "../../assets/svgs/icons/CameraIcon";
import ImageBrowseIcon from "../../assets/svgs/icons/ImageBrowseIcon";
import * as ImagePicker from "expo-image-picker";
import {AntherContext} from "../../contexts/AntheraContext";
import AppError from "../../components/shared/AppError";
import {DuplicateEmail} from "../../api/ApiConstants";

const ProfilePictureScreen=({route, navigation}:NativeStackScreenProps<StackParamList, 'ProfilePictureScreen'>)=>{
    const userInfoContext = useContext(UserInfoContext);
    const antheraContext = useContext(AntherContext);

    const [picture, setPicture] = useState<string|undefined>(userInfoContext?.profilePictureUrl?userInfoContext.profilePictureUrl:undefined);
    const [error, setError] = useState<string>();

    const semiBottomModalRef = useRef<RBSheet>();

    const onContinue = async () => {
        //sign up user
        const signup:SignupRequest={
            ...userInfoContext
        }

        if(antheraContext!=null && userInfoContext!=null){
            const signupRes:AntheraResponse = await signupAsync(signup, antheraContext);
            const token = antheraContext.token;

            if(signupRes.statusCode!=200){
                if(signupRes.errorMsg==DuplicateEmail){
                    userInfoContext.emailDuplicateError="Sorry, account with this email already exists."
                    navigation.navigate('EmailAndPasswordScreen',{p:'error'});
                }
                setError('Sorry, something went wrong signing you up.');
                return;
            }

            //upload picture
            if(userInfoContext.profilePictureUrl && token!=null){
                const uploadRes = await uploadImgAsync(userInfoContext.profilePictureUrl, token);

                if(uploadRes.statusCode!=200){
                    setError('Sorry, something went wrong uploading your photo.');
                    return;
                }
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

        if(userInfoContext!=null){
            userInfoContext.profilePictureUrl=result.uri;
            setPicture(result.uri);
        }

        semiBottomModalRef.current?.close();
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
            {picture == undefined && <FemaleAvatar {...styles.svg}/>}
            {picture && <Image source={{uri:picture}} style={[styles.svg, {borderRadius:moderateScale(100)}]}/>}
        </TouchableOpacity>

        <AppError errorMsg={error} style={{alignSelf:'center'}}/>

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
