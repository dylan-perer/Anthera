import * as React from "react"
import Svg, { Path, Circle } from "react-native-svg"

const SvgComponent = (props) => (
    <Svg
        xmlns="http://www.w3.org/2000/svg"
        width={20.125}
        height={25.459}
        viewBox="0 0 20.125 25.459"
        {...props}
    >
        <Path d="M19.72 3.637v3.637H.404V3.637H19.72Z" fill="#726360" />
        <Path d="m18.144 7.274-.606 4.849H2.546L1.98 7.274Z" fill="#c7cfd2" />
        <Path
            d="m18.144 12.123-.808 7.274H2.788l-.808-7.274h16.164Zm-5.658 3.637a2.223 2.223 0 1 0-2.223 2.223 2.242 2.242 0 0 0 2.224-2.223Z"
            fill="#8f7a62"
        />
        <Path d="m16.528.404.808 3.233H2.788L3.556.404Z" fill="#857470" />
        <Path
            d="m16.649 19.397-.606 5.011a1.22 1.22 0 0 1-1.208 1.051H5.253a1.22 1.22 0 0 1-1.212-1.051l-.606-5.011Z"
            fill="#c7cfd2"
        />
        <Circle
            cx={2.223}
            cy={2.223}
            r={2.223}
            transform="translate(8.042 13.538)"
            fill="#095742"
        />
        <Path
            d="M19.721 7.678H.4a.382.382 0 0 1-.4-.4V3.633a.382.382 0 0 1 .4-.4h2.388v.808H.808V6.87h18.549V4.041h-2.021v-.808h2.384a.382.382 0 0 1 .4.4V7.27a.382.382 0 0 1-.399.408Z"
            fill="#726360"
        />
        <Path
            d="M17.336 4.041H2.784a.368.368 0 0 1-.323-.162.486.486 0 0 1-.077-.323L3.152.323a.435.435 0 0 1 .4-.323h12.976a.394.394 0 0 1 .4.323l.808 3.233a.412.412 0 0 1-.081.364.335.335 0 0 1-.319.121ZM3.313 3.233h13.538L16.245.808H3.884Z"
            fill="#857470"
        />
        <Path
            d="M17.336 19.801H2.788a.43.43 0 0 1-.4-.364l-.812-7.273a.761.761 0 0 1 .081-.323c.04-.081.2-.121.323-.121h16.164a.315.315 0 0 1 .283.121.435.435 0 0 1 .081.323l-.808 7.274a.362.362 0 0 1-.364.363Zm-14.184-.808h13.824l.727-6.466H2.425Z"
            fill="#8f7a62"
        />
    </Svg>
)

export default SvgComponent
