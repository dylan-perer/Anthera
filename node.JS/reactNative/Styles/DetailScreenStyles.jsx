import { AntheraStyle } from "./AntheraStyles"
const DetailScreenStyles = {
    anim: {
        topTextAnim: {
            animation: {
                0: {
                    opacity: 0
                },
                1: {
                    opacity: 1
                },
                duration: 2000
            }
        },
        svgAnim: {
            animation: {
                0: {
                    opacity: 0
                },
                1: {
                    opacity: 1
                },
                duration: 2000
            }
        }

    },
    topText: {
        fontFamily: AntheraStyle.font.Questrial,
        fontSize: AntheraStyle.font.size.header,
        color: AntheraStyle.colour.TextGrey
    },
    topTextPrimary: {
        color: AntheraStyle.colour.MainBlue
    },
}



export { DetailScreenStyles }