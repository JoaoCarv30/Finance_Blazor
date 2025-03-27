/** @type {import('tailwindcss').Config} */
export default {
    content: ["./**/*.{html,js,razor,cshtml}"],
    theme: {
        extend: {

            fontFamily: {
                roboto: ['Roboto', 'sans-serif'],
            },
            colors: {
                "white-50" : "#E5E7EB",
                "purple": "#6933FF",
                "purple-50": "#5429CC",
                "mygreen": "#33CC95",
                "myred" : "#E52E4C",
                "mywhite": "#F4F4F4",
            }

        },
    },
    plugins: [],
}