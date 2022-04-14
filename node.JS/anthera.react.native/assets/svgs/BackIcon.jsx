import * as React from "react"
import Svg, { G, Rect } from "react-native-svg"
import {AntheraStyle} from "../../styles/AntheraStyle";
const SvgComponent = (props) => (
    <Svg
        xmlns="http://www.w3.org/2000/svg"
        width={20.506}
        height={36.213}
        viewBox="0 0 20.506 36.213"
        {...props}
    >
        <G transform="translate(-49.469 -69.383)" fill={AntheraStyle.colour.main}>
            <Rect
                width={4}
                height={25}
                rx={2}
                transform="rotate(-45 130.862 -15.755)"
            />
            <Rect
                width={4}
                height={25}
                rx={2}
                transform="rotate(-135 44.765 34.113)"
            />
        </G>
    </Svg>
)

export default SvgComponent
