public bool PodeFazerCheckIn(Hospede hospede)
{
    // Verifica se o hóspede tem uma reserva válida
    var reservaValida = _repositorioDeReservas.ExisteReservaValidaParaHospede(hospede);

    return reservaValida;
}
