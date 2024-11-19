import { MyAlert } from './MyAlert';


const Home = () => {
    return (
        <MyAlert
            head = "Головна сторінка"
            type = "success"
        >             
            Тут будуть блоки для відображення статистики по бібліотеці (список з 5 найпопулярніших книжок, та з 5 найактивніших читачів)
        </MyAlert>          
    )
}
export {Home}