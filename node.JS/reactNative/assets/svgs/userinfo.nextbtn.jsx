import * as React from "react"
import Svg, { Defs, G, Circle, Path } from "react-native-svg"
/* SVGR has dropped some elements not supported by react-native-svg: filter */

const SvgComponent = (props) => (
  <Svg xmlns="http://www.w3.org/2000/svg" width={98} height={98} viewBox="0 0 98 98" {...props}>
    <Defs></Defs>
    <G filter="url(#a)">
      <Circle
        cx={41.5}
        cy={41.5}
        r={41.5}
        transform="translate(7.5 3.5)"
        fill="#2170fc"
      />
    </G>
    <Path
      fill="none"
      stroke="#fff"
      strokeWidth={4}
      d="m39 27 19 21M40 68l20-21"
    />
  </Svg>
)

export default SvgComponent
