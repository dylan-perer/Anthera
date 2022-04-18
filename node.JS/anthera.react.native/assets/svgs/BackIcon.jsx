import * as React from "react"
import Svg, { G, Rect } from "react-native-svg"
import {AntheraStyle} from "../../styles/AntheraStyle";

const SvgComponent = (props) => (
    <Svg
        xmlns="http://www.w3.org/2000/svg"
        width={19.092}
        height={36.213}
        viewBox="0 0 19.092 36.213"
        {...props}
    >
        <G transform="translate(-49.469 -69.383)" fill={AntheraStyle.colour.IconGrey}>
            <Rect
                width={2}
                height={25}
                rx={1}
                transform="rotate(-45 130.862 -15.755)"
            />
            <Rect width={2} height={25} rx={1} transform="rotate(-135 43.765 33.7)" />
        </G>
    </Svg>
)

export default SvgComponent
