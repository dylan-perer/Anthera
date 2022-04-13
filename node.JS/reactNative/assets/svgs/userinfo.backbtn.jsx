import * as React from "react"
import Svg, { Defs, G, Circle, Path } from "react-native-svg"
/* SVGR has dropped some elements not supported by react-native-svg: filter */

const SvgComponent = (props) => (
  <Svg
    xmlns="http://www.w3.org/2000/svg"
    width={77.593}
    height={77.593}
    viewBox="0 0 77.593 77.593"
    {...props}
  >
    <Defs></Defs>
    <G transform="translate(0 .003)" filter="url(#a)">
      <G transform="translate(7.5 3.5)" fill="#fff" stroke="#85b4fc">
        <Circle cx={31.296} cy={31.296} r={31.296} stroke="none" />
        <Circle cx={31.296} cy={31.296} r={30.796} fill="none" />
      </G>
    </G>
    <Path
      d="M38.796 19.714 27.977 36.292"
      fill="#85b4fc"
      stroke="#85b4fc"
      strokeWidth={4}
    />
    <Path
      fill="none"
      stroke="#85b4fc"
      strokeWidth={4}
      d="M38.279 50.634 27.928 34.797"
    />
  </Svg>
)

export default SvgComponent
