import * as React from "react"
import Svg, { Path } from "react-native-svg"

const SvgComponent = (props) => (
    <Svg xmlns="http://www.w3.org/2000/svg" width={21} height={18.617} {...props} viewBox="0 0 21 18.617">
        <Path
            d="M10.506 3.93 9.24 2.59a4.8 4.8 0 0 0-6.883-.158h0a4.565 4.565 0 0 0-.158 6.329l1.978 1.978 6.329 6.883 6.329-6.883.791-.87-6.566-6.572ZM18.66 2.348h0a4.872 4.872 0 0 0-6.883.158l-.712.791 6.567 6.567 1.108-1.187a4.489 4.489 0 0 0-.08-6.329Z"
            fill="#ff71a7"
            stroke="#ff71a7"
            strokeLinecap="round"
            strokeLinejoin="round"
            strokeMiterlimit={10}
            strokeWidth={2}
        />
    </Svg>
)

export default SvgComponent
