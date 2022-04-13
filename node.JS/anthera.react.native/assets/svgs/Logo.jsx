import * as React from "react"
import Svg, { G, Path } from "react-native-svg"
import {AntheraStyle} from "../../styles/AntheraStyle";
const SvgComponent = (props) => (
    <Svg
        xmlns="http://www.w3.org/2000/svg"
        width={65.718}
        height={67.938}
        viewBox="0 0 65.718 67.938"
        {...props}
    >
        <G fillRule="evenodd">
            <Path
                d="m24.528 40.493-.487 17.857-15.4 9.587 8.942-7.69 6.948-19.753ZM23.365 12.563 17.265 0l25.347 7.563-11.732 7.96-7.51-2.96Z"
                fill={AntheraStyle.colour.Secondary}
            />
            <Path
                d="m8.638 67.937 15.899-27.214-7.169 20.683-8.73 6.53Z"
                fill={AntheraStyle.colour.main}
            />
            <Path
                d="m24.121 54.279 30.386-16.444-25.93-6.443-4.456 9.594Z"
                fill={AntheraStyle.colour.main}
            />
            <Path
                d="m28.135 32.977.683-22.74L0 6.209l28.135 26.768Z"
                fill={AntheraStyle.colour.main}
            />
            <Path
                d="M54.711 37.87 30.589 15.158l11.975-7.675c.855.979 10.683 26.576 12 30.008l.146.38Z"
                fill={AntheraStyle.colour.Secondary}
            />
            <Path d="M54.602 37.908 28.764 10.193l-.838 22.6Z" fill={AntheraStyle.colour.dark}/>
            <Path d="m61.689 24.888 4.025 12.532-8.7-4.28Z" fill={AntheraStyle.colour.Secondary} />
            <Path d="m54.575 37.905 7.237-13.015-11.223 2.391" fill={AntheraStyle.colour.main} />
        </G>
    </Svg>
)

export default SvgComponent
